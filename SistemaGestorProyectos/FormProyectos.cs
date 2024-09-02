using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    public partial class FormProyectos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public FormProyectos()
        {
            InitializeComponent();
            LoadProyectos();
            LoadDepartamentos();
        }

        private void LoadProyectos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Proyectos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProyectos.DataSource = dt;
            }
        }

        private void LoadDepartamentos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DepartamentoID, NombreDepartamento FROM Departamentos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbDepartamento.DataSource = dt;
                cbDepartamento.DisplayMember = "NombreDepartamento";
                cbDepartamento.ValueMember = "DepartamentoID";
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrEmpty(txtPortafolio.Text))
            {
                MessageBox.Show("Por favor, ingresa un portafolio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPortafolio.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNombreProyecto.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre para el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProyecto.Focus();
                return;
            }

            if (!int.TryParse(txtAño.Text, out int año) || año < 1980 || año > DateTime.Now.Year)
            {
                MessageBox.Show("Por favor, ingresa un año válido entre 1980 y " + DateTime.Now.Year + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return;
            }

            if (!int.TryParse(txtTrimestre.Text, out int trimestre) || trimestre < 1 || trimestre > 4)
            {
                MessageBox.Show("Por favor, ingresa un trimestre válido (1 a 4).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrimestre.Focus();
                return;
            }

            if (cbDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDepartamento.Focus();
                return;
            }

            if (dtpFechaCierre.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha de cierre no puede ser anterior a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaCierre.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Proyectos (Portafolio, NombreProyecto, Año, Trimestre, Descripción, Tipo, FechaInicio, FechaCierre, DepartamentoID) " +
                                   "VALUES (@Portafolio, @Nombre, @Año, @Trimestre, @Descripcion, @Tipo, @FechaInicio, @FechaCierre, @DepartamentoID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Portafolio", txtPortafolio.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreProyecto.Text.Trim());
                    cmd.Parameters.AddWithValue("@Año", año);
                    cmd.Parameters.AddWithValue("@Trimestre", trimestre);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaInicio", dtpFechaInicio.Value);
                    cmd.Parameters.AddWithValue("@FechaCierre", dtpFechaCierre.Value);
                    cmd.Parameters.AddWithValue("@DepartamentoID", cbDepartamento.SelectedValue);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Proyecto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProyectos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al agregar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar agregar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormProyectos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProyectos();
        }
    }
}
