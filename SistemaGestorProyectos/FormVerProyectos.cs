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
    public partial class FormVerProyectos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public FormVerProyectos()
        {
            InitializeComponent();
            LoadProyectos();
        }

        private void LoadProyectos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT p.ProyectoID, p.NombreProyecto, d.NombreDepartamento 
            FROM Proyectos p
            INNER JOIN Departamentos d ON p.DepartamentoID = d.DepartamentoID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvVerProyectos.DataSource = dt;
            }
        }
    }

}
