﻿namespace SistemaGestorProyectos
{
    partial class FormDepartamentos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Jefe = new System.Windows.Forms.Label();
            this.comboJefe = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 148);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(170, 148);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(301, 28);
            this.dgvDepartamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.RowHeadersWidth = 51;
            this.dgvDepartamentos.Size = new System.Drawing.Size(740, 561);
            this.dgvDepartamentos.TabIndex = 2;
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(28, 48);
            this.txtNombreDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(132, 22);
            this.txtNombreDepartamento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de Departamento ";
            // 
            // Jefe
            // 
            this.Jefe.AutoSize = true;
            this.Jefe.Location = new System.Drawing.Point(28, 79);
            this.Jefe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jefe.Name = "Jefe";
            this.Jefe.Size = new System.Drawing.Size(33, 16);
            this.Jefe.TabIndex = 7;
            this.Jefe.Text = "Jefe";
            // 
            // comboJefe
            // 
            this.comboJefe.FormattingEnabled = true;
            this.comboJefe.Location = new System.Drawing.Point(28, 98);
            this.comboJefe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboJefe.Name = "comboJefe";
            this.comboJefe.Size = new System.Drawing.Size(160, 24);
            this.comboJefe.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Actualizar Tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboJefe);
            this.Controls.Add(this.Jefe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Jefe;
        private System.Windows.Forms.ComboBox comboJefe;
        private System.Windows.Forms.Button button1;
    }
}