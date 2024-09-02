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
    public partial class FormEmpleados : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public FormEmpleados()
        {
            InitializeComponent();
            LoadEmpleados();
        }

        private void LoadEmpleados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Empleados";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvEmpleados.DataSource = dt;
            }
        }
    }

}
