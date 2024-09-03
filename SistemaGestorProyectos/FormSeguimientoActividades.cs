using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    /// <summary>
    /// Formulario para gestionar el seguimiento de actividades.
    /// Permite visualizar, agregar y modificar el estado de actividades.
    /// </summary>
    public partial class FormSeguimientoActividades : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormSeguimientoActividades.
        /// Inicializa los componentes del formulario y carga los datos de seguimiento, actividades, empleados y estados.
        /// </summary>
        public FormSeguimientoActividades()
        {
            InitializeComponent();
            LoadSeguimiento();
            LoadActividades();
            LoadEmpleados();
            LoadEstados(); // Cargar los estados en los ComboBox
        }

        /// <summary>
        /// Carga la información de seguimiento en el DataGridView.
        /// </summary>
        private void LoadSeguimiento()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Seguimiento";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSeguimientoActividades.DataSource = dt;
            }
        }

        /// <summary>
        /// Carga las actividades disponibles en el ComboBox.
        /// </summary>
        private void LoadActividades()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ActividadID, Tipo FROM Actividad";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbActividades.DataSource = dt;
                cbActividades.DisplayMember = "Tipo";
                cbActividades.ValueMember = "ActividadID";
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
        /// Carga los estados disponibles en los ComboBox para los estados anterior y nuevo.
        /// </summary>
        private void LoadEstados()
        {
            // Suponiendo que los estados son "Testing", "Revisión", "Finalizada"
            var estados = new List<string> { "Testing", "Revisión", "Finalizada" };

            // Configurar el ComboBox para Estado Anterior
            cbEstadoAnterior.DataSource = estados;

            // Configurar el ComboBox para Estado Nuevo
            cbEstadoNuevo.DataSource = estados;
        }

        /// <summary>
        /// Maneja el evento de clic del botón Agregar.
        /// Inserta un nuevo registro de seguimiento en la base de datos.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (cbActividades.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona una actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEmpleados.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un empleado responsable.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEstadoAnterior.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona el estado anterior.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEstadoNuevo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona el estado nuevo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Por favor, ingresa un comentario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insertar datos en la base de datos
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Seguimiento (ActividadID, EstadoAnterior, EstadoNuevo, FechaCambio, UsuarioResponsable, Comentario) VALUES (@ActividadID, @EstadoAnterior, @EstadoNuevo, @FechaCambio, @UsuarioResponsable, @Comentario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ActividadID", cbActividades.SelectedValue);
                cmd.Parameters.AddWithValue("@EstadoAnterior", cbEstadoAnterior.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@EstadoNuevo", cbEstadoNuevo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@FechaCambio", dtpFechaCambio.Value);
                cmd.Parameters.AddWithValue("@UsuarioResponsable", cbEmpleados.SelectedValue);
                cmd.Parameters.AddWithValue("@Comentario", txtComentario.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadSeguimiento();
            }
        }
    }
}
