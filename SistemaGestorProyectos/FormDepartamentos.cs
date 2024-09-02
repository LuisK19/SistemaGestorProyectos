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
    public partial class FormDepartamentos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public FormDepartamentos()
        {
            InitializeComponent();
            LoadDepartamentos();

        }


        private void LoadDepartamentos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                // Cargar los departamentos en el DataGridView
                string queryDepartamentos = "SELECT * FROM Departamentos";
                using (SqlDataAdapter adapterDepartamentos = new SqlDataAdapter(queryDepartamentos, conn))
                {
                    DataTable dtDepartamentos = new DataTable();
                    adapterDepartamentos.Fill(dtDepartamentos);
                    dgvDepartamentos.DataSource = dtDepartamentos;
                }

                // Cargar los empleados en el ComboBox
                string queryEmpleados = "SELECT EmpleadoID, Nombre + ' ' + Apellido AS NombreCompleto FROM Empleados";
                using (SqlDataAdapter adapterEmpleados = new SqlDataAdapter(queryEmpleados, conn))
                {
                    DataTable dtEmpleados = new DataTable();
                    adapterEmpleados.Fill(dtEmpleados);
                    comboJefe.DataSource = dtEmpleados;
                    comboJefe.DisplayMember = "NombreCompleto";
                    comboJefe.ValueMember = "EmpleadoID";
                }
            }
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Agregando departamento...");
            if (string.IsNullOrEmpty(txtCodigoDepartamento.Text) || string.IsNullOrEmpty(txtNombreDepartamento.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
            MessageBox.Show("Campos completos.");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Departamentos (CodigoDepartamento, NombreDepartamento, JefeEmpleadoID) VALUES (@Codigo, @Nombre, @Jefe)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Codigo", txtCodigoDepartamento.Text);
                command.Parameters.AddWithValue("@Nombre", txtNombreDepartamento.Text);
                command.Parameters.AddWithValue("@Jefe", Convert.ToInt32(comboJefe.SelectedValue));

                conn.Open();
                int result = command.ExecuteNonQuery();

                // Verificar si se agregó correctamente
                if (result > 0)
                {
                    MessageBox.Show("Departamento agregado exitosamente.");
                    // Aquí podrías querer recargar los datos en el DataGridView
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar el departamento.");
                }
                MessageBox.Show("Departamento agregado correctamente.");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count > 0)
            {
                int departamentoID = Convert.ToInt32(dgvDepartamentos.SelectedRows[0].Cells["DepartamentoID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Departamentos WHERE DepartamentoID = @DepartamentoID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DepartamentoID", departamentoID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadDepartamentos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDepartamentos();

        }
    }

}
