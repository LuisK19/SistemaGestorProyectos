using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    public partial class FormPersonaPorProyecto : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public FormPersonaPorProyecto()
        {
            InitializeComponent();
            LoadProyectoEmpleados();
            LoadProyectos();
            LoadEmpleados();
        }

        private void LoadProyectoEmpleados()
        {
            // Establece la conexión con la base de datos usando la cadena de conexión proporcionada
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Consulta SQL para obtener los nombres de los proyectos y empleados, así como sus IDs
                string query = @"
            SELECT 
                p.ProyectoID AS 'ProyectoID',
                e.EmpleadoID AS 'EmpleadoID',
                p.NombreProyecto AS 'Nombre del Proyecto', 
                e.Nombre AS 'Nombre del Empleado' 
            FROM ProyectoEmpleados pe
            INNER JOIN Proyectos p ON pe.ProyectoID = p.ProyectoID
            INNER JOIN Empleados e ON pe.EmpleadoID = e.EmpleadoID";

                // Crea un adaptador de datos para ejecutar la consulta y llenar un DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                // Crea un DataTable para almacenar los resultados de la consulta
                DataTable dt = new DataTable();

                // Llena el DataTable con los datos obtenidos de la consulta
                adapter.Fill(dt);

                // Asigna el DataTable como origen de datos para el DataGridView
                dgvPersonaPorProyecto.DataSource = dt;
            }
        }



        private void LoadProyectos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProyectoID, NombreProyecto FROM Proyectos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbProyectos.DataSource = dt;
                cbProyectos.DisplayMember = "NombreProyecto";
                cbProyectos.ValueMember = "ProyectoID";
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Validar que se ha seleccionado un proyecto y un empleado
            if (cbProyectos.SelectedValue == null || cbEmpleados.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un proyecto y un empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ProyectoEmpleados (ProyectoID, EmpleadoID) VALUES (@ProyectoID, @EmpleadoID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProyectoID", cbProyectos.SelectedValue);
                cmd.Parameters.AddWithValue("@EmpleadoID", cbEmpleados.SelectedValue);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadProyectoEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar la relación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (IsRowSelected(out int proyectoID, out int empleadoID))
            {
                if (DeletePersonaPorProyecto(proyectoID, empleadoID))
                {
                    LoadProyectoEmpleados();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la relación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsRowSelected(out int proyectoID, out int empleadoID)
        {
            // Inicializar los valores de salida
            proyectoID = 0;
            empleadoID = 0;

            // Verificar que se ha seleccionado una fila en el DataGridView
            if (dgvPersonaPorProyecto.SelectedRows.Count > 0)
            {
                // Obtener el DataGridViewRow seleccionado
                DataGridViewRow selectedRow = dgvPersonaPorProyecto.SelectedRows[0];

                // Obtener los valores de ID usando los nombres de las columnas actuales
                // Asegúrate de que los nombres de las columnas en el DataGridView coincidan con los usados aquí
                if (selectedRow.Cells["ProyectoID"] != null && selectedRow.Cells["EmpleadoID"] != null)
                {
                    proyectoID = Convert.ToInt32(selectedRow.Cells["ProyectoID"].Value);
                    empleadoID = Convert.ToInt32(selectedRow.Cells["EmpleadoID"].Value);
                    return true;
                }
                else
                {
                    MessageBox.Show("Las columnas 'ProyectoID' o 'EmpleadoID' no se encontraron en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }




        private bool DeletePersonaPorProyecto(int proyectoID, int empleadoID)
        {
            try
            {
                // Establecer la conexión con la base de datos
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Consulta para eliminar el registro
                    string query = "DELETE FROM PersonaPorProyecto WHERE ProyectoID = @ProyectoID AND EmpleadoID = @EmpleadoID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProyectoID", proyectoID);
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                    // Abrir la conexión y ejecutar el comando
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    // Verificar si se eliminó alguna fila
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al eliminar la relación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }




    }
}
