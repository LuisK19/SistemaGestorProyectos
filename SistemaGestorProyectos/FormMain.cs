using System;
using System.Windows.Forms;

namespace SistemaGestorProyectos
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeTabs();
        }

        private void InitializeTabs()
        {
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // Crear una pestaña para FormProyectos
            TabPage tabProyectos = new TabPage("Proyectos");
            FormProyectos formProyectos = new FormProyectos();
            formProyectos.TopLevel = false;
            formProyectos.Dock = DockStyle.Fill;
            formProyectos.FormBorderStyle = FormBorderStyle.None;
            tabProyectos.Controls.Add(formProyectos);
            formProyectos.Show();

            // Crear una pestaña para FormDepartamentos
            TabPage tabDepartamentos = new TabPage("Departamentos");
            FormDepartamentos formDepartamentos = new FormDepartamentos();
            formDepartamentos.TopLevel = false;
            formDepartamentos.Dock = DockStyle.Fill;
            formDepartamentos.FormBorderStyle = FormBorderStyle.None;
            tabDepartamentos.Controls.Add(formDepartamentos);
            formDepartamentos.Show();

            // Crear una pestaña para FormActividades
            TabPage tabActividades = new TabPage("Actividades");
            FormActividades formActividades = new FormActividades();
            formActividades.TopLevel = false;
            formActividades.Dock = DockStyle.Fill;
            formActividades.FormBorderStyle = FormBorderStyle.None;
            tabActividades.Controls.Add(formActividades);
            formActividades.Show();

            TabPage tabSeguimientoActividades = new TabPage("Seguimiento de Actividades");
            FormSeguimientoActividades formSeguimientoActividades = new FormSeguimientoActividades();
            formSeguimientoActividades.TopLevel = false;
            formSeguimientoActividades.Dock = DockStyle.Fill;
            formSeguimientoActividades.FormBorderStyle = FormBorderStyle.None;
            tabSeguimientoActividades.Controls.Add(formSeguimientoActividades);
            formSeguimientoActividades.Show();

            TabPage tabPersonasPorProyecto = new TabPage("Personas por Proyecto");
            FormPersonaPorProyecto formPersonaPorProyecto = new FormPersonaPorProyecto();
            formPersonaPorProyecto.TopLevel = false;
            formPersonaPorProyecto.Dock = DockStyle.Fill;
            formPersonaPorProyecto.FormBorderStyle = FormBorderStyle.None;
            tabPersonasPorProyecto.Controls.Add(formPersonaPorProyecto);
            formPersonaPorProyecto.Show();

            TabPage tabEmpleados = new TabPage("Empleados");
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.TopLevel = false;
            formEmpleados.Dock = DockStyle.Fill;
            formEmpleados.FormBorderStyle = FormBorderStyle.None;
            tabEmpleados.Controls.Add(formEmpleados);
            formEmpleados.Show();

            TabPage tabVerDepartamentos = new TabPage("Ver Departamentos");
            FormVerDepartamentos formVerDepartamentos = new FormVerDepartamentos();
            formVerDepartamentos.TopLevel = false;
            formVerDepartamentos.Dock = DockStyle.Fill;
            formVerDepartamentos.FormBorderStyle = FormBorderStyle.None;
            tabVerDepartamentos.Controls.Add(formVerDepartamentos);
            formVerDepartamentos.Show();

            TabPage tabVerProyectos = new TabPage("Ver Proyectos");
            FormVerProyectos formVerProyectos = new FormVerProyectos();
            formVerProyectos.TopLevel = false;
            formVerProyectos.Dock = DockStyle.Fill;
            formVerProyectos.FormBorderStyle = FormBorderStyle.None;
            tabVerProyectos.Controls.Add(formVerProyectos);
            formVerProyectos.Show();

            // Agregar las pestañas al TabControl
            tabControl.TabPages.Add(tabProyectos);
            tabControl.TabPages.Add(tabDepartamentos);
            tabControl.TabPages.Add(tabActividades);
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
