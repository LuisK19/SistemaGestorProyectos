namespace SistemaGestorProyectos
{
    partial class FormTareas
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
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionTarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorasEsfuerzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoTarea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 263);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(172, 32);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(574, 375);
            this.dgvTareas.TabIndex = 1;
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(25, 48);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTarea.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombe de la Tarea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion de la Tarea";
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.Location = new System.Drawing.Point(25, 106);
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionTarea.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horas de Esfuerzo";
            // 
            // txtHorasEsfuerzo
            // 
            this.txtHorasEsfuerzo.Location = new System.Drawing.Point(25, 163);
            this.txtHorasEsfuerzo.Name = "txtHorasEsfuerzo";
            this.txtHorasEsfuerzo.Size = new System.Drawing.Size(100, 20);
            this.txtHorasEsfuerzo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // txtTipoTarea
            // 
            this.txtTipoTarea.Location = new System.Drawing.Point(25, 219);
            this.txtTipoTarea.Name = "txtTipoTarea";
            this.txtTipoTarea.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTarea.TabIndex = 8;
            // 
            // FormTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoTarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorasEsfuerzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreTarea);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormTareas";
            this.Text = "FormTareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionTarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHorasEsfuerzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoTarea;
    }
}