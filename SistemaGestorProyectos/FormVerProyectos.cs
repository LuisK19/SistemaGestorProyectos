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
    /// Formulario para visualizar la información de los proyectos.
    /// Muestra los datos de la tabla Proyecto en un DataGridView.
    /// </summary>
    public partial class FormVerProyectos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormVerProyectos.
        /// Inicializa los componentes del formulario y carga la información de los proyectos.
        /// </summary>
        public FormVerProyectos()
        {
            InitializeComponent();
            LoadProyectos();
        }

        /// <summary>
        /// Carga la información de los proyectos en el DataGridView.
        /// La consulta SQL obtiene el ID del proyecto, el nombre del proyecto y el nombre del departamento asociado.
        /// </summary>
        private void LoadProyectos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT p.ProyectoID, p.NombreProyecto, d.NombreDepartamento 
                    FROM Proyecto p
                    INNER JOIN Departamento d ON p.DepartamentoID = d.DepartamentoID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvVerProyectos.DataSource = dt;
            }
        }
    }
}
