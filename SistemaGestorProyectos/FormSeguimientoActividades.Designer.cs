namespace SistemaGestorProyectos
{
    partial class FormSeguimientoActividades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbActividades = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvSeguimientoActividades = new System.Windows.Forms.DataGridView();
            this.dtpFechaCambio = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoAnterior = new System.Windows.Forms.ComboBox();
            this.cbEstadoNuevo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimientoActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado Anterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(25, 175);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(100, 20);
            this.txtComentario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Cambio";
            // 
            // cbActividades
            // 
            this.cbActividades.FormattingEnabled = true;
            this.cbActividades.Location = new System.Drawing.Point(25, 223);
            this.cbActividades.Name = "cbActividades";
            this.cbActividades.Size = new System.Drawing.Size(121, 21);
            this.cbActividades.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Actividades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Empleados";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(25, 269);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleados.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 312);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvSeguimientoActividades
            // 
            this.dgvSeguimientoActividades.AllowUserToAddRows = false;
            this.dgvSeguimientoActividades.AllowUserToDeleteRows = false;
            this.dgvSeguimientoActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguimientoActividades.Location = new System.Drawing.Point(248, 22);
            this.dgvSeguimientoActividades.Name = "dgvSeguimientoActividades";
            this.dgvSeguimientoActividades.ReadOnly = true;
            this.dgvSeguimientoActividades.Size = new System.Drawing.Size(540, 406);
            this.dgvSeguimientoActividades.TabIndex = 13;
            // 
            // dtpFechaCambio
            // 
            this.dtpFechaCambio.Location = new System.Drawing.Point(25, 129);
            this.dtpFechaCambio.Name = "dtpFechaCambio";
            this.dtpFechaCambio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCambio.TabIndex = 14;
            // 
            // cbEstadoAnterior
            // 
            this.cbEstadoAnterior.FormattingEnabled = true;
            this.cbEstadoAnterior.Location = new System.Drawing.Point(25, 38);
            this.cbEstadoAnterior.Name = "cbEstadoAnterior";
            this.cbEstadoAnterior.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoAnterior.TabIndex = 15;
            // 
            // cbEstadoNuevo
            // 
            this.cbEstadoNuevo.FormattingEnabled = true;
            this.cbEstadoNuevo.Location = new System.Drawing.Point(25, 86);
            this.cbEstadoNuevo.Name = "cbEstadoNuevo";
            this.cbEstadoNuevo.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoNuevo.TabIndex = 16;
            // 
            // FormSeguimientoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbEstadoNuevo);
            this.Controls.Add(this.cbEstadoAnterior);
            this.Controls.Add(this.dtpFechaCambio);
            this.Controls.Add(this.dgvSeguimientoActividades);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActividades);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSeguimientoActividades";
            this.Text = "FormSeguimientoActividades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimientoActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbActividades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvSeguimientoActividades;
        private System.Windows.Forms.DateTimePicker dtpFechaCambio;
        private System.Windows.Forms.ComboBox cbEstadoAnterior;
        private System.Windows.Forms.ComboBox cbEstadoNuevo;
    }
}