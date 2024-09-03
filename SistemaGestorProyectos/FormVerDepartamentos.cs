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
    /// <summary>
    /// Formulario para visualizar la información de los departamentos.
    /// Muestra los datos de la tabla Departamento en un DataGridView.
    /// </summary>
    public partial class FormVerDepartamentos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormVerDepartamentos.
        /// Inicializa los componentes del formulario y carga la información de los departamentos.
        /// </summary>
        public FormVerDepartamentos()
        {
            InitializeComponent();
            LoadDepartamentos();
        }

        /// <summary>
        /// Carga la información de los departamentos en el DataGridView.
        /// </summary>
        private void LoadDepartamentos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Departamento";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvVerDepartamentos.DataSource = dt;
            }
        }
    }
}
