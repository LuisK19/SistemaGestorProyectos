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
    public partial class FormVerDepartamentos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public FormVerDepartamentos()
        {
            InitializeComponent();
            LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Departamentos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvVerDepartamentos.DataSource = dt;
            }
        }
    }

}
