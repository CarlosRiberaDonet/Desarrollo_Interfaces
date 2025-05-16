namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.etiquetaInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(156, 126);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(200, 20);
            this.fechaInicio.TabIndex = 0;
            this.fechaInicio.ValueChanged += new System.EventHandler(this.fechaInicio_ValueChanged);
            // 
            // fechaFin
            // 
            this.fechaFin.Location = new System.Drawing.Point(156, 188);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(200, 20);
            this.fechaFin.TabIndex = 1;
            this.fechaFin.ValueChanged += new System.EventHandler(this.fechaFin_ValueChanged);
            // 
            // etiquetaInicio
            // 
            this.etiquetaInicio.AutoSize = true;
            this.etiquetaInicio.Location = new System.Drawing.Point(99, 132);
            this.etiquetaInicio.Name = "etiquetaInicio";
            this.etiquetaInicio.Size = new System.Drawing.Size(35, 13);
            this.etiquetaInicio.TabIndex = 2;
            this.etiquetaInicio.Text = "label1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.etiquetaInicio);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaInicio);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.Label etiquetaInicio;
    }
}
