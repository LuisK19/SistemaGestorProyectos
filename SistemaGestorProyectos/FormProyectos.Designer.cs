﻿namespace SistemaGestorProyectos
{
    partial class FormProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortafolio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrimestre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 568);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(360, 36);
            this.dgvProyectos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.Size = new System.Drawing.Size(729, 574);
            this.dgvProyectos.TabIndex = 1;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(20, 511);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(135, 24);
            this.cbDepartamento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 491);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departamento";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(17, 55);
            this.txtNombreProyecto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(132, 22);
            this.txtNombreProyecto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de Proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Portafolio";
            // 
            // txtPortafolio
            // 
            this.txtPortafolio.Location = new System.Drawing.Point(17, 112);
            this.txtPortafolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPortafolio.Name = "txtPortafolio";
            this.txtPortafolio.Size = new System.Drawing.Size(132, 22);
            this.txtPortafolio.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Año";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(17, 169);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(132, 22);
            this.txtAño.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Trimestre";
            // 
            // txtTrimestre
            // 
            this.txtTrimestre.Location = new System.Drawing.Point(17, 231);
            this.txtTrimestre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrimestre.Name = "txtTrimestre";
            this.txtTrimestre.Size = new System.Drawing.Size(132, 22);
            this.txtTrimestre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(17, 295);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcion.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(17, 353);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(132, 22);
            this.txtTipo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 388);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha de Inicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 436);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha de Cierre";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(16, 404);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(139, 22);
            this.dtpFechaInicio.TabIndex = 23;
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCierre.Location = new System.Drawing.Point(16, 456);
            this.dtpFechaCierre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(139, 22);
            this.dtpFechaCierre.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Actualizar Tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(172, 52);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(121, 24);
            this.cbEmpleados.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Empleado";
            // 
            // FormProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 623);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpFechaCierre);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrimestre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPortafolio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProyectos";
            this.Text = "FormProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortafolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrimestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label10;
    }
}