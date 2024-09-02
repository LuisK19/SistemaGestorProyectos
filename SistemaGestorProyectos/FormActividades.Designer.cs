namespace SistemaGestorProyectos
{
    partial class FormActividades
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
            this.cbTareas = new System.Windows.Forms.ComboBox();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.dtpFechaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.FechayHoraInicio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.cbEtapa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTareas
            // 
            this.cbTareas.FormattingEnabled = true;
            this.cbTareas.Location = new System.Drawing.Point(20, 240);
            this.cbTareas.Name = "cbTareas";
            this.cbTareas.Size = new System.Drawing.Size(121, 21);
            this.cbTareas.TabIndex = 0;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(20, 295);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(125, 335);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de Horas";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(22, 29);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 7;
            // 
            // dtpFechaHoraInicio
            // 
            this.dtpFechaHoraInicio.Location = new System.Drawing.Point(20, 133);
            this.dtpFechaHoraInicio.Name = "dtpFechaHoraInicio";
            this.dtpFechaHoraInicio.Size = new System.Drawing.Size(232, 20);
            this.dtpFechaHoraInicio.TabIndex = 8;
            // 
            // FechayHoraInicio
            // 
            this.FechayHoraInicio.AutoSize = true;
            this.FechayHoraInicio.Location = new System.Drawing.Point(20, 114);
            this.FechayHoraInicio.Name = "FechayHoraInicio";
            this.FechayHoraInicio.Size = new System.Drawing.Size(114, 13);
            this.FechayHoraInicio.TabIndex = 9;
            this.FechayHoraInicio.Text = "Fecha y Hora de Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha y Hora de Cierre";
            // 
            // dtpFechaHoraFin
            // 
            this.dtpFechaHoraFin.Location = new System.Drawing.Point(20, 188);
            this.dtpFechaHoraFin.Name = "dtpFechaHoraFin";
            this.dtpFechaHoraFin.Size = new System.Drawing.Size(232, 20);
            this.dtpFechaHoraFin.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Etapa";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(22, 75);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo";
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(258, 28);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.Size = new System.Drawing.Size(520, 394);
            this.dgvActividades.TabIndex = 16;
            // 
            // cbEtapa
            // 
            this.cbEtapa.FormattingEnabled = true;
            this.cbEtapa.Location = new System.Drawing.Point(131, 28);
            this.cbEtapa.Name = "cbEtapa";
            this.cbEtapa.Size = new System.Drawing.Size(121, 21);
            this.cbEtapa.TabIndex = 17;
            // 
            // FormActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEtapa);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaHoraFin);
            this.Controls.Add(this.FechayHoraInicio);
            this.Controls.Add(this.dtpFechaHoraInicio);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.cbTareas);
            this.Name = "FormActividades";
            this.Text = "FormActividades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTareas;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraInicio;
        private System.Windows.Forms.Label FechayHoraInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.ComboBox cbEtapa;
    }
}