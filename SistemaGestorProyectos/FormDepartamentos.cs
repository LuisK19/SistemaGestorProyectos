using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    /// <summary>
    /// Formulario para la gestión de departamentos en el sistema de proyectos.
    /// Permite visualizar, agregar y eliminar departamentos.
    /// </summary>
    public partial class FormDepartamentos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormDepartamentos.
        /// Inicializa los componentes del formulario y carga los datos en los controles.
        /// </summary>
        public FormDepartamentos()
        {
            InitializeComponent();
            LoadDepartamentos();
        }

        /// <summary>
        /// Carga los departamentos y los empleados desde la base de datos.
        /// Muestra los departamentos en el DataGridView y los empleados en el ComboBox.
        /// </summary>
        private void LoadDepartamentos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Cargar los departamentos en el DataGridView
                string queryDepartamento = "SELECT * FROM Departamento";
                using (SqlDataAdapter adapterDepartamento = new SqlDataAdapter(queryDepartamento, conn))
                {
                    DataTable dtDepartamento = new DataTable();
                    adapterDepartamento.Fill(dtDepartamento);
                    dgvDepartamentos.DataSource = dtDepartamento;
                }

                // Cargar los empleados en el ComboBox
                string queryEmpleados = "SELECT CedulaEmpleado, Nombre + ' ' + Apellidos AS NombreCompleto FROM Empleado";
                using (SqlDataAdapter adapterEmpleados = new SqlDataAdapter(queryEmpleados, conn))
                {
                    DataTable dtEmpleados = new DataTable();
                    adapterEmpleados.Fill(dtEmpleados);
                    comboJefe.DataSource = dtEmpleados;
                    comboJefe.DisplayMember = "NombreCompleto";
                    comboJefe.ValueMember = "CedulaEmpleado";
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Agregar.
        /// Valida el nombre del departamento ingresado, lo inserta en la base de datos y recarga la lista de departamentos.
        /// </summary>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreDepartamento.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre para el departamento.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Departamento (NombreDepartamento, CedulaJefe) VALUES (@Nombre, @Jefe)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Nombre", txtNombreDepartamento.Text.Trim());
                command.Parameters.AddWithValue("@Jefe", Convert.ToInt32(comboJefe.SelectedValue));

                conn.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Departamento agregado exitosamente.");
                    LoadDepartamentos();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar el departamento.");
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Eliminar.
        /// Elimina el departamento seleccionado en el DataGridView y recarga la lista de departamentos.
        /// </summary>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count > 0)
            {
                int departamentoID = Convert.ToInt32(dgvDepartamentos.SelectedRows[0].Cells["DepartamentoID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Departamento WHERE DepartamentoID = @DepartamentoID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DepartamentoID", departamentoID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadDepartamentos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Actualizar.
        /// Recarga la lista de departamentos desde la base de datos.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDepartamentos();
        }
    }
}
