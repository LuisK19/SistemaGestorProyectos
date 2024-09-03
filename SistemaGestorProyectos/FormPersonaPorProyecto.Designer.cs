namespace SistemaGestorProyectos
{
    partial class FormPersonaPorProyecto
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
            this.cbProyectos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.dgvPersonaPorProyecto = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonaPorProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProyectos
            // 
            this.cbProyectos.FormattingEnabled = true;
            this.cbProyectos.Location = new System.Drawing.Point(36, 65);
            this.cbProyectos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProyectos.Name = "cbProyectos";
            this.cbProyectos.Size = new System.Drawing.Size(160, 24);
            this.cbProyectos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleado";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(36, 134);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(160, 24);
            this.cbEmpleados.TabIndex = 2;
            // 
            // dgvPersonaPorProyecto
            // 
            this.dgvPersonaPorProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonaPorProyecto.Location = new System.Drawing.Point(285, 26);
            this.dgvPersonaPorProyecto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPersonaPorProyecto.Name = "dgvPersonaPorProyecto";
            this.dgvPersonaPorProyecto.RowHeadersWidth = 51;
            this.dgvPersonaPorProyecto.Size = new System.Drawing.Size(765, 513);
            this.dgvPersonaPorProyecto.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(35, 167);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(156, 167);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormPersonaPorProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPersonaPorProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProyectos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPersonaPorProyecto";
            this.Text = "FormPersonaPorProyecto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonaPorProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.DataGridView dgvPersonaPorProyecto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
    }
}