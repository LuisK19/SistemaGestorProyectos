using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    public partial class FormActividades : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public FormActividades()
        {
            InitializeComponent();
            LoadActividades();
            LoadTareas();
            LoadEmpleados();
            InitializeEtapas(); // Inicializar las etapas en el ComboBox
            dtpFechaHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";

            dtpFechaHoraFin.Format = DateTimePickerFormat.Custom;
            dtpFechaHoraFin.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void LoadActividades()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Actividades";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvActividades.DataSource = dt;
            }
        }

        private void LoadTareas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TareaID, NombreTarea FROM Tareas";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbTareas.DataSource = dt;
                cbTareas.DisplayMember = "NombreTarea";
                cbTareas.ValueMember = "TareaID";
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

        private void InitializeEtapas()
        {
            // Configurar el ComboBox con las opciones permitidas
            cbEtapa.Items.Add("Testing");
            cbEtapa.Items.Add("Revisión");
            cbEtapa.Items.Add("Finalizada");
            cbEtapa.SelectedIndex = 0; // Establecer el valor predeterminado (opcional)
        }

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
                string query = "INSERT INTO Actividades (TareaID, EmpleadoID, FechaHoraInicio, FechaHoraFin, Horas, Tipo, Etapa) VALUES (@TareaID, @EmpleadoID, @FechaHoraInicio, @FechaHoraFin, @Horas, @Tipo, @Etapa)";
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvActividades.SelectedRows.Count > 0)
            {
                int actividadID = Convert.ToInt32(dgvActividades.SelectedRows[0].Cells["ActividadID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Actividades WHERE ActividadID = @ActividadID";
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
