using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    /// <summary>
    /// Formulario para gestionar la relación entre proyectos y empleados.
    /// Permite visualizar, agregar y eliminar asignaciones de empleados a proyectos.
    /// </summary>
    public partial class FormPersonaPorProyecto : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormPersonaPorProyecto.
        /// Inicializa los componentes del formulario y carga los datos de proyectos y empleados.
        /// </summary>
        public FormPersonaPorProyecto()
        {
            InitializeComponent();
            LoadProyectosEmpleados();
            LoadProyectos();
            LoadEmpleados();
        }

        /// <summary>
        /// Carga la relación entre proyectos y empleados en el DataGridView.
        /// </summary>
        private void LoadProyectosEmpleados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    p.ProyectoID AS 'ProyectoID',
                    e.CedulaEmpleado AS 'EmpleadoID',
                    p.NombreProyecto AS 'Nombre del Proyecto', 
                    e.Nombre + ' ' + e.Apellidos AS 'Nombre del Empleado'
                FROM Proyecto p
                INNER JOIN Empleado e ON p.CedulaEmpleado = e.CedulaEmpleado";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPersonaPorProyecto.DataSource = dt;
            }
        }

        /// <summary>
        /// Carga los proyectos disponibles en el ComboBox.
        /// </summary>
        private void LoadProyectos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProyectoID, NombreProyecto FROM Proyecto";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbProyectos.DataSource = dt;
                cbProyectos.DisplayMember = "NombreProyecto";
                cbProyectos.ValueMember = "ProyectoID";
            }
        }

        /// <summary>
        /// Carga los empleados disponibles en el ComboBox.
        /// </summary>
        private void LoadEmpleados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CedulaEmpleado, Nombre + ' ' + Apellidos AS NombreCompleto FROM Empleado";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbEmpleados.DataSource = dt;
                cbEmpleados.DisplayMember = "NombreCompleto";
                cbEmpleados.ValueMember = "CedulaEmpleado";
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Agregar.
        /// Asocia un empleado seleccionado con un proyecto.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbProyectos.SelectedValue == null || cbEmpleados.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un proyecto y un empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Proyecto SET CedulaEmpleado = @EmpleadoID WHERE ProyectoID = @ProyectoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProyectoID", cbProyectos.SelectedValue);
                cmd.Parameters.AddWithValue("@EmpleadoID", cbEmpleados.SelectedValue);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadProyectosEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar la relación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Eliminar.
        /// Elimina la asignación de un empleado a un proyecto.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(out int proyectoID, out int empleadoID))
            {
                if (DeletePersonaPorProyecto(proyectoID, empleadoID))
                {
                    LoadProyectosEmpleados();
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

        /// <summary>
        /// Verifica si una fila está seleccionada en el DataGridView y obtiene los IDs de proyecto y empleado.
        /// </summary>
        /// <param name="proyectoID">ID del proyecto seleccionado.</param>
        /// <param name="empleadoID">ID del empleado seleccionado.</param>
        /// <returns>True si se seleccionó una fila y se obtuvieron los IDs; de lo contrario, false.</returns>
        private bool IsRowSelected(out int proyectoID, out int empleadoID)
        {
            proyectoID = 0;
            empleadoID = 0;

            if (dgvPersonaPorProyecto.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPersonaPorProyecto.SelectedRows[0];

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

        /// <summary>
        /// Elimina la relación entre un proyecto y un empleado.
        /// </summary>
        /// <param name="proyectoID">ID del proyecto.</param>
        /// <param name="empleadoID">ID del empleado.</param>
        /// <returns>True si la eliminación fue exitosa; de lo contrario, false.</returns>
        private bool DeletePersonaPorProyecto(int proyectoID, int empleadoID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Proyecto SET CedulaEmpleado = NULL WHERE ProyectoID = @ProyectoID AND CedulaEmpleado = @EmpleadoID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProyectoID", proyectoID);
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la relación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
