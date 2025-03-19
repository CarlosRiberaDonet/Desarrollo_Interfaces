using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form1: Form
    {
        DataTable productos;

        private void cargarDatos()
        {
            productos = this.dataSet11.catalogo;
            listView1.Items.Clear();
            foreach(DataRow producto in productos.Rows)
            {
                ListViewItem item = listView1.Items.Add(producto["id"].ToString());
                item.SubItems.Add(producto["componente"].ToString());
                item.SubItems.Add(producto["precio"].ToString());
                item.SubItems.Add(producto["marca"].ToString());
                item.SubItems.Add(producto["categoría"].ToString());
                item.SubItems.Add("-");
                item.SubItems.Add("+");
                item.SubItems.Add("0"); // Cantidad por defecto
            }

        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.dataSet1.marcas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.componentes' Puede moverla o quitarla según sea necesario.
            this.componentesTableAdapter.Fill(this.dataSet11.componentes);
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.dataSet11.categorias);
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.catalogo' Puede moverla o quitarla según sea necesario.
            this.catalogoTableAdapter.Fill(this.dataSet11.catalogo);
            cargarDatos();

        }

      

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarCategoria();
        }

        private void FiltrarCategoria()
        {
            productos = this.dataSet11.catalogo;
            listView1.Items.Clear();

            foreach (DataRow producto in productos.Rows)
            {
                if (!showCategoria(producto) || !showMarca(producto) || !showPrecio(producto)) continue;
                {
                    ListViewItem item = listView1.Items.Add(producto["id"].ToString());
                    item.SubItems.Add(producto["componente"].ToString());
                    item.SubItems.Add(producto["precio"].ToString());
                    item.SubItems.Add(producto["marca"].ToString());
                    item.SubItems.Add(producto["categoría"].ToString());
                    item.SubItems.Add("-");             
                    item.SubItems.Add("+");
                    item.SubItems.Add("0"); // Cantidad por defecto

                }
                
            }
        }

        private Boolean showPrecio(DataRow producto)
        {
            if (cmbPrecio.SelectedItem == null)
            {
                cmbPrecio.SelectedItem = "Todos";
            }
            decimal precioProducto = Convert.ToDecimal(producto["precio"]);
            string rangoPrecios = cmbPrecio.Text.Trim(); // Eliminar espacios extra

            // Verificar el rango de precios seleccionado
            if (rangoPrecios == "Todos") return true;
            if (rangoPrecios == "0 - 50" && precioProducto >= 0 && precioProducto <= 50) return true;
            if (rangoPrecios == "50 - 100" && precioProducto > 50 && precioProducto <= 100) return true;
            if (rangoPrecios == "100 - 200" && precioProducto > 100 && precioProducto <= 200) return true;
            if (rangoPrecios == "200 - 400" && precioProducto > 200 && precioProducto <= 400) return true;
            if (rangoPrecios == ">400" && precioProducto > 400) return true;

            return false;

        }

        
        private Boolean showCategoria(DataRow producto)
        {
            if (cmbCategoria.Text != producto["categoría"].ToString()) return false;
            return true;
        }

        private Boolean showMarca(DataRow producto)
        {
            if (cmbMarca.Text != producto["marca"].ToString()) return false;
            return true;
        }
    }
}
