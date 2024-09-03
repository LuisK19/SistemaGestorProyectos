using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    /// <summary>
    /// Formulario para la gestión de empleados en el sistema de proyectos.
    /// Permite visualizar una lista de empleados en el DataGridView.
    /// </summary>
    public partial class FormEmpleados : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormEmpleados.
        /// Inicializa los componentes del formulario y carga los datos de los empleados.
        /// </summary>
        public FormEmpleados()
        {
            InitializeComponent();
            LoadEmpleados();
        }

        /// <summary>
        /// Carga los empleados desde la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void LoadEmpleados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Empleado";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvEmpleados.DataSource = dt;
            }
        }
    }
}
