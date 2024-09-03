using System;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    /// <summary>
    /// Formulario principal de la aplicación que actúa como contenedor para varias pestañas,
    /// cada una con un formulario diferente para gestionar distintas áreas del sistema.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Constructor del formulario FormMain.
        /// Inicializa los componentes del formulario y configura las pestañas.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeTabs();
        }

        /// <summary>
        /// Inicializa las pestañas del formulario principal.
        /// Crea instancias de los formularios para cada área de gestión y los agrega como pestañas.
        /// </summary>
        private void InitializeTabs()
        {
            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            // Crear y configurar la pestaña para FormProyectos
            TabPage tabProyectos = new TabPage("Proyectos");
            FormProyectos formProyectos = new FormProyectos
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabProyectos.Controls.Add(formProyectos);
            formProyectos.Show();

            // Crear y configurar la pestaña para FormDepartamentos
            TabPage tabDepartamentos = new TabPage("Departamentos");
            FormDepartamentos formDepartamentos = new FormDepartamentos
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabDepartamentos.Controls.Add(formDepartamentos);
            formDepartamentos.Show();

            // Crear y configurar la pestaña para FormActividades
            TabPage tabActividades = new TabPage("Actividades");
            FormActividades formActividades = new FormActividades
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabActividades.Controls.Add(formActividades);
            formActividades.Show();

            // Crear y configurar la pestaña para FormTareas
            TabPage tabTarea = new TabPage("Tareas");
            FormTareas formTareas = new FormTareas
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabTarea.Controls.Add(formTareas);
            formTareas.Show();

            // Crear y configurar la pestaña para FormSeguimientoActividades
            TabPage tabSeguimientoActividades = new TabPage("Seguimiento de Actividades");
            FormSeguimientoActividades formSeguimientoActividades = new FormSeguimientoActividades
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabSeguimientoActividades.Controls.Add(formSeguimientoActividades);
            formSeguimientoActividades.Show();

            // Crear y configurar la pestaña para FormPersonaPorProyecto
            TabPage tabPersonasPorProyecto = new TabPage("Personas por Proyecto");
            FormPersonaPorProyecto formPersonaPorProyecto = new FormPersonaPorProyecto
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabPersonasPorProyecto.Controls.Add(formPersonaPorProyecto);
            formPersonaPorProyecto.Show();

            // Crear y configurar la pestaña para FormEmpleados
            TabPage tabEmpleados = new TabPage("Empleados");
            FormEmpleados formEmpleados = new FormEmpleados
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabEmpleados.Controls.Add(formEmpleados);
            formEmpleados.Show();

            // Crear y configurar la pestaña para FormVerDepartamentos
            TabPage tabVerDepartamentos = new TabPage("Ver Departamentos");
            FormVerDepartamentos formVerDepartamentos = new FormVerDepartamentos
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabVerDepartamentos.Controls.Add(formVerDepartamentos);
            formVerDepartamentos.Show();

            // Crear y configurar la pestaña para FormVerProyectos
            TabPage tabVerProyectos = new TabPage("Ver Proyectos");
            FormVerProyectos formVerProyectos = new FormVerProyectos
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            tabVerProyectos.Controls.Add(formVerProyectos);
            formVerProyectos.Show();

            // Agregar las pestañas al TabControl
            tabControl.TabPages.Add(tabProyectos);
            tabControl.TabPages.Add(tabDepartamentos);
            tabControl.TabPages.Add(tabActividades);
            tabControl.TabPages.Add(tabTarea);
            tabControl.TabPages.Add(tabSeguimientoActividades);
            tabControl.TabPages.Add(tabPersonasPorProyecto);
            tabControl.TabPages.Add(tabEmpleados);
            tabControl.TabPages.Add(tabVerDepartamentos);
            tabControl.TabPages.Add(tabVerProyectos);

            // Agregar el TabControl al formulario principal
            this.Controls.Add(tabControl);
        }
    }
}
