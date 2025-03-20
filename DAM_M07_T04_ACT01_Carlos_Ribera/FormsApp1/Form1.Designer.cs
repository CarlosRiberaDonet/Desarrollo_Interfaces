namespace FormsApp1
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet11 = new FormsApp1.DataSet1();
            this.listaPrincipal = new System.Windows.Forms.ListView();
            this.coumndaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComlumnaComponente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoTableAdapter = new FormsApp1.DataSet1TableAdapters.catalogoTableAdapter();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new FormsApp1.DataSet1TableAdapters.categoriasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FormsApp1.DataSet1();
            this.componentesTableAdapter = new FormsApp1.DataSet1TableAdapters.componentesTableAdapter();
            this.catalogoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.componentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new FormsApp1.DataSet1TableAdapters.marcasTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPrecio = new System.Windows.Forms.ComboBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCarrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaPrincipal
            // 
            this.listaPrincipal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coumndaId,
            this.ComlumnaComponente,
            this.columnaPrecio,
            this.columnaMarca,
            this.columnCategoria});
            this.listaPrincipal.FullRowSelect = true;
            this.listaPrincipal.HideSelection = false;
            this.listaPrincipal.Location = new System.Drawing.Point(12, 75);
            this.listaPrincipal.Name = "listaPrincipal";
            this.listaPrincipal.Size = new System.Drawing.Size(776, 300);
            this.listaPrincipal.TabIndex = 0;
            this.listaPrincipal.UseCompatibleStateImageBehavior = false;
            this.listaPrincipal.View = System.Windows.Forms.View.Details;
            // 
            // coumndaId
            // 
            this.coumndaId.Text = "id";
            this.coumndaId.Width = 50;
            // 
            // ComlumnaComponente
            // 
            this.ComlumnaComponente.Text = "Componente";
            this.ComlumnaComponente.Width = 300;
            // 
            // columnaPrecio
            // 
            this.columnaPrecio.Text = "Precio";
            this.columnaPrecio.Width = 50;
            // 
            // columnaMarca
            // 
            this.columnaMarca.Text = "Marca";
            this.columnaMarca.Width = 80;
            // 
            // columnCategoria
            // 
            this.columnCategoria.Text = "Categoria";
            this.columnCategoria.Width = 80;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "catalogo";
            this.bindingSource1.DataSource = this.dataSet11;
            // 
            // catalogoTableAdapter
            // 
            this.catalogoTableAdapter.ClearBeforeFill = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataSource = this.categoriasBindingSource;
            this.cmbCategoria.DisplayMember = "nombre";
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(73, 22);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.ValueMember = "id";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.dataSet11;
            // 
            // catalogoBindingSource
            // 
            this.catalogoBindingSource.DataMember = "catalogo";
            this.catalogoBindingSource.DataSource = this.dataSet11;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DataSource = this.marcasBindingSource;
            this.cmbMarca.DisplayMember = "marca";
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(262, 22);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 4;
            this.cmbMarca.ValueMember = "marca";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "marcas";
            this.marcasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componentesTableAdapter
            // 
            this.componentesTableAdapter.ClearBeforeFill = true;
            // 
            // catalogoBindingSource1
            // 
            this.catalogoBindingSource1.DataMember = "catalogo";
            this.catalogoBindingSource1.DataSource = this.dataSet11;
            // 
            // componentesBindingSource
            // 
            this.componentesBindingSource.DataMember = "componentes";
            this.componentesBindingSource.DataSource = this.dataSet11;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // cmbPrecio
            // 
            this.cmbPrecio.FormattingEnabled = true;
            this.cmbPrecio.Items.AddRange(new object[] {
            "Todos",
            "0 - 50",
            "50 - 100",
            "100 - 200",
            "200 - 400",
            ">400"});
            this.cmbPrecio.Location = new System.Drawing.Point(461, 22);
            this.cmbPrecio.Name = "cmbPrecio";
            this.cmbPrecio.Size = new System.Drawing.Size(121, 21);
            this.cmbPrecio.TabIndex = 6;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(605, 22);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 7;
            this.buttonFiltrar.Text = "FILTRAR";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(461, 406);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCarrito
            // 
            this.buttonCarrito.Location = new System.Drawing.Point(605, 406);
            this.buttonCarrito.Name = "buttonCarrito";
            this.buttonCarrito.Size = new System.Drawing.Size(183, 23);
            this.buttonCarrito.TabIndex = 10;
            this.buttonCarrito.Text = "Ir al Carrito";
            this.buttonCarrito.UseVisualStyleBackColor = true;
            this.buttonCarrito.Click += new System.EventHandler(this.buttonCarrito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCarrito);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.cmbPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.listaPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet11;
        private System.Windows.Forms.ListView listaPrincipal;
        private System.Windows.Forms.ColumnHeader coumndaId;
        private System.Windows.Forms.ColumnHeader ComlumnaComponente;
        private System.Windows.Forms.ColumnHeader columnaPrecio;
        private System.Windows.Forms.ColumnHeader columnaMarca;
        private System.Windows.Forms.ColumnHeader columnCategoria;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet1TableAdapters.catalogoTableAdapter catalogoTableAdapter;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.BindingSource catalogoBindingSource;
        private DataSet1TableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarca;
        private DataSet1TableAdapters.componentesTableAdapter componentesTableAdapter;
        private System.Windows.Forms.BindingSource catalogoBindingSource1;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.BindingSource componentesBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private DataSet1TableAdapters.marcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPrecio;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCarrito;
    }
}

