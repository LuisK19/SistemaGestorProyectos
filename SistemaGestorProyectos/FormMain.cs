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

            // Agregar las pestañas al TabControl
            tabControl.TabPages.Add(tabProyectos);
            tabControl.TabPages.Add(tabDepartamentos);

            // Agregar el TabControl al formulario principal
            this.Controls.Add(tabControl);
        }
    }
}
