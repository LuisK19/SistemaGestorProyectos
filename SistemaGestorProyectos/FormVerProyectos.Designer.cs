namespace SistemaGestorProyectos
{
    partial class FormVerProyectos
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
            this.dgvVerProyectos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerProyectos
            // 
            this.dgvVerProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerProyectos.Location = new System.Drawing.Point(25, 22);
            this.dgvVerProyectos.Name = "dgvVerProyectos";
            this.dgvVerProyectos.Size = new System.Drawing.Size(763, 416);
            this.dgvVerProyectos.TabIndex = 0;
            // 
            // FormVerProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVerProyectos);
            this.Name = "FormVerProyectos";
            this.Text = "FormVerProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerProyectos;
    }
}