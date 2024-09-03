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
    /// Formulario para gestionar las tareas del proyecto.
    /// Permite visualizar y agregar nuevas tareas.
    /// </summary>
    public partial class FormTareas : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormTareas.
        /// Inicializa los componentes del formulario y carga las tareas.
        /// </summary>
        public FormTareas()
        {
            InitializeComponent();
            LoadTareas();
        }

        /// <summary>
        /// Carga la información de las tareas en el DataGridView.
        /// </summary>
        private void LoadTareas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tarea";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTareas.DataSource = dt;
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Agregar.
        /// Valida los datos ingresados y agrega una nueva tarea a la base de datos.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombreTarea.Text))
            {
                MessageBox.Show("El nombre de la tarea es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionTarea.Text))
            {
                MessageBox.Show("La descripción de la tarea es obligatoria.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtHorasEsfuerzo.Text, out int horasEsfuerzo) || horasEsfuerzo <= 0)
            {
                MessageBox.Show("Las horas de esfuerzo deben ser un número entero positivo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipoTarea.Text))
            {
                MessageBox.Show("El tipo de tarea es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todas las validaciones pasan, se procede a agregar la tarea
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Tarea (NombreTarea, Descripción, HorasEsfuerzo, Tipo) VALUES (@Nombre, @Descripcion, @HorasEsfuerzo, @Tipo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombreTarea.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcionTarea.Text);
                cmd.Parameters.AddWithValue("@HorasEsfuerzo", horasEsfuerzo);
                cmd.Parameters.AddWithValue("@Tipo", txtTipoTarea.Text);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Tarea agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTareas(); // Recargar el DataGridView con los datos actualizados
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// Este método está vacío y puede ser utilizado para inicializaciones adicionales si es necesario.
        /// </summary>
        private void FormTareas_Load(object sender, EventArgs e)
        {
            // Inicializaciones adicionales pueden ser agregadas aquí.
        }
    }
}
