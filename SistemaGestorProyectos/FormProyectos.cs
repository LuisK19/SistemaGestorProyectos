using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    /// <summary>
    /// Formulario para gestionar los proyectos en el sistema.
    /// Permite visualizar, agregar y actualizar proyectos.
    /// </summary>
    public partial class FormProyectos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Constructor del formulario FormProyectos.
        /// Inicializa los componentes del formulario y carga los datos de proyectos, departamentos y empleados.
        /// </summary>
        public FormProyectos()
        {
            InitializeComponent();
            LoadProyectos();
            LoadDepartamentos();
            LoadEmpleados();
        }

        /// <summary>
        /// Carga la lista de proyectos en el DataGridView.
        /// </summary>
        private void LoadProyectos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProyectoID, NombreProyecto, NombrePortafolio, Año, Trimestre, Descripcion, Tipo, FechaProyectadaInicio, FechaProyectadaCierre, DepartamentoID FROM Proyecto";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProyectos.DataSource = dt;
            }
        }

        /// <summary>
        /// Carga los departamentos disponibles en el ComboBox.
        /// </summary>
        private void LoadDepartamentos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DepartamentoID, NombreDepartamento FROM Departamento";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbDepartamento.DataSource = dt;
                cbDepartamento.DisplayMember = "NombreDepartamento";
                cbDepartamento.ValueMember = "DepartamentoID";
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
        /// Valida los campos del formulario y agrega un nuevo proyecto a la base de datos.
        /// </summary>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrEmpty(txtPortafolio.Text))
            {
                MessageBox.Show("Por favor, ingresa un portafolio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPortafolio.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNombreProyecto.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre para el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProyecto.Focus();
                return;
            }

            if (!int.TryParse(txtAño.Text, out int año) || año < 1980 || año > DateTime.Now.Year)
            {
                MessageBox.Show("Por favor, ingresa un año válido entre 1980 y " + DateTime.Now.Year + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return;
            }

            if (!int.TryParse(txtTrimestre.Text, out int trimestre) || trimestre < 1 || trimestre > 4)
            {
                MessageBox.Show("Por favor, ingresa un trimestre válido (1 a 4).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrimestre.Focus();
                return;
            }

            if (cbDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDepartamento.Focus();
                return;
            }

            if (dtpFechaCierre.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha de cierre no puede ser anterior a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaCierre.Focus();
                return;
            }

            if (cbEmpleados.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un empleado para el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbEmpleados.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Obtener el empleado seleccionado
                    int empleadoSeleccionado = Convert.ToInt32(cbEmpleados.SelectedValue);

                    // Crear el comando SQL para insertar el proyecto
                    string query = "INSERT INTO Proyecto (NombrePortafolio, NombreProyecto, Año, Trimestre, Descripcion, Tipo, FechaProyectadaInicio, FechaProyectadaCierre, DepartamentoID, CedulaEmpleado) " +
                                   "VALUES (@Portafolio, @Nombre, @Año, @Trimestre, @Descripcion, @Tipo, @FechaInicio, @FechaCierre, @DepartamentoID, @CedulaEmpleado)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Portafolio", txtPortafolio.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreProyecto.Text.Trim());
                    cmd.Parameters.AddWithValue("@Año", año);
                    cmd.Parameters.AddWithValue("@Trimestre", trimestre);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaInicio", dtpFechaInicio.Value);
                    cmd.Parameters.AddWithValue("@FechaCierre", dtpFechaCierre.Value);
                    cmd.Parameters.AddWithValue("@DepartamentoID", cbDepartamento.SelectedValue);
                    cmd.Parameters.AddWithValue("@CedulaEmpleado", empleadoSeleccionado);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Proyecto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProyectos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al agregar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar agregar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic del botón Actualizar.
        /// Recarga los datos de proyectos en el DataGridView.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            LoadProyectos();
        }
    }
}
