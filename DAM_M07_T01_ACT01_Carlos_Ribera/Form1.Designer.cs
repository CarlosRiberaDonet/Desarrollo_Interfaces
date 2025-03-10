namespace DAM_M07_T01_ACT01_Carlos_Ribera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombreTareaLabel = new Label();
            txtNombreTarea = new TextBox();
            descripcionTareaLabel = new Label();
            txtDescripcionTarea = new TextBox();
            fechaEntregaLabel = new Label();
            fechaEntrega = new DateTimePicker();
            tipoEntregaLabel = new Label();
            cmbTipoEntrega = new ComboBox();
            extensionesValidasLabel = new Label();
            comentariosRetroaccionLabel = new Label();
            chkRetroaccion = new CheckBox();
            crearTareaButton = new Button();
            cmbExtensionesValidas = new ComboBox();
            SuspendLayout();
            // 
            // nombreTareaLabel
            // 
            nombreTareaLabel.AccessibleName = "";
            nombreTareaLabel.AutoSize = true;
            nombreTareaLabel.Location = new Point(30, 35);
            nombreTareaLabel.Name = "nombreTareaLabel";
            nombreTareaLabel.Size = new Size(54, 15);
            nombreTareaLabel.TabIndex = 0;
            nombreTareaLabel.Text = "Nombre:";
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(90, 29);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.Size = new Size(124, 23);
            txtNombreTarea.TabIndex = 1;
            // 
            // descripcionTareaLabel
            // 
            descripcionTareaLabel.AccessibleName = "";
            descripcionTareaLabel.AutoSize = true;
            descripcionTareaLabel.Location = new Point(12, 61);
            descripcionTareaLabel.Name = "descripcionTareaLabel";
            descripcionTareaLabel.Size = new Size(72, 15);
            descripcionTareaLabel.TabIndex = 2;
            descripcionTareaLabel.Text = "Descripción:";
            // 
            // txtDescripcionTarea
            // 
            txtDescripcionTarea.Location = new Point(90, 58);
            txtDescripcionTarea.Multiline = true;
            txtDescripcionTarea.Name = "txtDescripcionTarea";
            txtDescripcionTarea.Size = new Size(124, 23);
            txtDescripcionTarea.TabIndex = 3;
            // 
            // fechaEntregaLabel
            // 
            fechaEntregaLabel.AutoSize = true;
            fechaEntregaLabel.Location = new Point(331, 35);
            fechaEntregaLabel.Name = "fechaEntregaLabel";
            fechaEntregaLabel.Size = new Size(97, 15);
            fechaEntregaLabel.TabIndex = 4;
            fechaEntregaLabel.Text = "Fecha de entrega";
            // 
            // fechaEntrega
            // 
            fechaEntrega.CustomFormat = "dd/MM/yyyy HH:mm";
            fechaEntrega.Format = DateTimePickerFormat.Custom;
            fechaEntrega.Location = new Point(445, 29);
            fechaEntrega.Name = "fechaEntrega";
            fechaEntrega.Size = new Size(125, 23);
            fechaEntrega.TabIndex = 5;
            // 
            // tipoEntregaLabel
            // 
            tipoEntregaLabel.AccessibleName = "";
            tipoEntregaLabel.AutoSize = true;
            tipoEntregaLabel.Location = new Point(339, 64);
            tipoEntregaLabel.Name = "tipoEntregaLabel";
            tipoEntregaLabel.Size = new Size(89, 15);
            tipoEntregaLabel.TabIndex = 6;
            tipoEntregaLabel.Text = "Tipo de entrega";
            // 
            // cmbTipoEntrega
            // 
            cmbTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEntrega.FormattingEnabled = true;
            cmbTipoEntrega.Items.AddRange(new object[] { "Subir Fichero", "Texto en Linea", "Sin Entrega" });
            cmbTipoEntrega.Location = new Point(445, 61);
            cmbTipoEntrega.Name = "cmbTipoEntrega";
            cmbTipoEntrega.Size = new Size(125, 23);
            cmbTipoEntrega.TabIndex = 7;
            cmbTipoEntrega.SelectedIndexChanged += cmbTipoEntrega_SelectedIndexChanged;
            // 
            // extensionesValidasLabel
            // 
            extensionesValidasLabel.AccessibleName = "";
            extensionesValidasLabel.AutoSize = true;
            extensionesValidasLabel.Location = new Point(331, 98);
            extensionesValidasLabel.Name = "extensionesValidasLabel";
            extensionesValidasLabel.Size = new Size(108, 15);
            extensionesValidasLabel.TabIndex = 8;
            extensionesValidasLabel.Text = "Extensiones Válidas";
            // 
            // comentariosRetroaccionLabel
            // 
            comentariosRetroaccionLabel.AccessibleName = "";
            comentariosRetroaccionLabel.AutoSize = true;
            comentariosRetroaccionLabel.Location = new Point(12, 93);
            comentariosRetroaccionLabel.Name = "comentariosRetroaccionLabel";
            comentariosRetroaccionLabel.Size = new Size(154, 15);
            comentariosRetroaccionLabel.TabIndex = 10;
            comentariosRetroaccionLabel.Text = "Comentarios de retroacción";
            // 
            // chkRetroaccion
            // 
            chkRetroaccion.AutoSize = true;
            chkRetroaccion.Location = new Point(172, 95);
            chkRetroaccion.Name = "chkRetroaccion";
            chkRetroaccion.Size = new Size(68, 19);
            chkRetroaccion.TabIndex = 11;
            chkRetroaccion.Text = "Permitir";
            chkRetroaccion.UseVisualStyleBackColor = true;
            // 
            // crearTareaButton
            // 
            crearTareaButton.Location = new Point(314, 181);
            crearTareaButton.Name = "crearTareaButton";
            crearTareaButton.Size = new Size(108, 23);
            crearTareaButton.TabIndex = 12;
            crearTareaButton.Text = "Crear Tarea";
            crearTareaButton.UseVisualStyleBackColor = true;
            crearTareaButton.Click += crearTareaButton_Click;
            // 
            // cmbExtensionesValidas
            // 
            cmbExtensionesValidas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExtensionesValidas.Enabled = false;
            cmbExtensionesValidas.FormattingEnabled = true;
            cmbExtensionesValidas.Items.AddRange(new object[] { ".pdf", ".docx", ".xlsx", ".rar", ".zip", ".tar" });
            cmbExtensionesValidas.Location = new Point(445, 91);
            cmbExtensionesValidas.Name = "cmbExtensionesValidas";
            cmbExtensionesValidas.Size = new Size(125, 23);
            cmbExtensionesValidas.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 234);
            Controls.Add(cmbExtensionesValidas);
            Controls.Add(crearTareaButton);
            Controls.Add(chkRetroaccion);
            Controls.Add(comentariosRetroaccionLabel);
            Controls.Add(extensionesValidasLabel);
            Controls.Add(cmbTipoEntrega);
            Controls.Add(tipoEntregaLabel);
            Controls.Add(fechaEntrega);
            Controls.Add(fechaEntregaLabel);
            Controls.Add(txtDescripcionTarea);
            Controls.Add(descripcionTareaLabel);
            Controls.Add(txtNombreTarea);
            Controls.Add(nombreTareaLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreTareaLabel;
        private TextBox txtNombreTarea;
        private Label descripcionTareaLabel;
        private TextBox txtDescripcionTarea;
        private Label fechaEntregaLabel;
        private DateTimePicker fechaEntrega;
        private Label tipoEntregaLabel;
        private ComboBox cmbTipoEntrega;
        private Label extensionesValidasLabel;
        private Label comentariosRetroaccionLabel;
        private CheckBox chkRetroaccion;
        private Button crearTareaButton;
        private ComboBox cmbExtensionesValidas;
    }
}
