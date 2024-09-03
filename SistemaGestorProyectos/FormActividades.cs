using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    /// <summary>
    /// Formulario para la gestión de actividades en el sistema de proyectos.
    /// Permite visualizar, agregar y eliminar actividades asociadas a tareas y empleados.
    /// </summary>
    public partial class FormActividades : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormActividades.
        /// Inicializa los componentes del formulario, carga datos en los controles y configura los formatos de fecha.
        /// </summary>
        public FormActividades()
        {
            InitializeComponent();
            LoadActividades();
            LoadTareas();
            LoadEmpleados();
            InitializeEtapas(); // Inicializa las etapas en el ComboBox
            dtpFechaHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";

            dtpFechaHoraFin.Format = DateTimePickerFormat.Custom;
            dtpFechaHoraFin.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        /// <summary>
        /// Carga las actividades desde la base de datos y las muestra en el DataGridView.
        /// </summary>
        private void LoadActividades()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Actividad";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvActividades.DataSource = dt;
            }
        }

        /// <summary>
        /// Carga las tareas desde la base de datos y las muestra en el ComboBox.
        /// </summary>
        private void LoadTareas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TareaID, NombreTarea FROM Tarea";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbTareas.DataSource = dt;
                cbTareas.DisplayMember = "NombreTarea";
                cbTareas.ValueMember = "TareaID";
            }
        }

        /// <summary>
        /// Carga los empleados desde la base de datos y los muestra en el ComboBox.
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
        /// Inicializa el ComboBox de etapas con las opciones permitidas.
        /// </summary>
        private void InitializeEtapas()
        {
            cbEtapa.Items.Add("Testing");
            cbEtapa.Items.Add("Revisión");
            cbEtapa.Items.Add("Finalizada");
            cbEtapa.SelectedIndex = 0; // Establecer el valor predeterminado (opcional)
        }

        /// <summary>
        /// Maneja el evento de clic del botón Agregar.
        /// Valida los datos ingresados, los inserta en la base de datos y recarga las actividades.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cbTareas.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una tarea.");
                return;
            }
            if (cbEmpleados.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un empleado.");
                return;
            }
            if (string.IsNullOrEmpty(txtHoras.Text) || !int.TryParse(txtHoras.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa un número válido para horas.");
                return;
            }
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, ingresa el tipo de actividad.");
                return;
            }
            if (string.IsNullOrEmpty(cbEtapa.SelectedItem.ToString()) || !cbEtapa.Items.Contains(cbEtapa.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, selecciona una etapa válida.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Actividad (TareaID, CedulaEmpleado, FechaHoraInicio, FechaHoraFin, Horas, Tipo, Etapa) VALUES (@TareaID, @EmpleadoID, @FechaHoraInicio, @FechaHoraFin, @Horas, @Tipo, @Etapa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TareaID", cbTareas.SelectedValue);
                cmd.Parameters.AddWithValue("@EmpleadoID", cbEmpleados.SelectedValue);
                cmd.Parameters.AddWithValue("@FechaHoraInicio", dtpFechaHoraInicio.Value);
                cmd.Parameters.AddWithValue("@FechaHoraFin", dtpFechaHoraFin.Value);
                cmd.Parameters.AddWithValue("@Horas", txtHoras.Text);
                cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text);
                cmd.Parameters.AddWithValue("@Etapa", cbEtapa.SelectedItem.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadActividades();
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Eliminar.
        /// Elimina la actividad seleccionada en el DataGridView y recarga la lista de actividades.
        /// </summary>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvActividades.SelectedRows.Count > 0)
            {
                int actividadID = Convert.ToInt32(dgvActividades.SelectedRows[0].Cells["ActividadID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Actividad WHERE ActividadID = @ActividadID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ActividadID", actividadID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadActividades();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }
    }
}
