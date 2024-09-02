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
    public partial class FormSeguimientoActividades : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public FormSeguimientoActividades()
        {
            InitializeComponent();
            LoadSeguimientoActividades();
            LoadActividades();
            LoadEmpleados();
            LoadEstados(); // Cargar los estados en los ComboBox
        }

        private void LoadSeguimientoActividades()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SeguimientoActividades";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSeguimientoActividades.DataSource = dt;
            }
        }

        private void LoadActividades()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ActividadID, Tipo FROM Actividades";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbActividades.DataSource = dt;
                cbActividades.DisplayMember = "Tipo";
                cbActividades.ValueMember = "ActividadID";
            }
        }

        private void LoadEmpleados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT EmpleadoID, Nombre FROM Empleados";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbEmpleados.DataSource = dt;
                cbEmpleados.DisplayMember = "Nombre";
                cbEmpleados.ValueMember = "EmpleadoID";
            }
        }

        private void LoadEstados()
        {
            // Suponiendo que los estados son "Testing", "Revisión", "Finalizada"
            var estados = new List<string> { "Testing", "Revisión", "Finalizada" };

            // Configurar el ComboBox para Estado Anterior
            cbEstadoAnterior.DataSource = estados;


            // Configurar el ComboBox para Estado Nuevo
            cbEstadoNuevo.DataSource = estados;

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (cbActividades.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona una actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEmpleados.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un empleado responsable.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEstadoAnterior.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona el estado anterior.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEstadoNuevo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona el estado nuevo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Por favor, ingresa un comentario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insertar datos en la base de datos
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SeguimientoActividades (ActividadID, EstadoAnterior, EstadoNuevo, FechaCambio, UsuarioResponsable, Comentario) VALUES (@ActividadID, @EstadoAnterior, @EstadoNuevo, @FechaCambio, @UsuarioResponsable, @Comentario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ActividadID", cbActividades.SelectedValue);
                cmd.Parameters.AddWithValue("@EstadoAnterior", cbEstadoAnterior.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@EstadoNuevo", cbEstadoNuevo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@FechaCambio", dtpFechaCambio.Value);
                cmd.Parameters.AddWithValue("@UsuarioResponsable", cbEmpleados.SelectedValue);
                cmd.Parameters.AddWithValue("@Comentario", txtComentario.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadSeguimientoActividades();
            }
        }
    }



}
