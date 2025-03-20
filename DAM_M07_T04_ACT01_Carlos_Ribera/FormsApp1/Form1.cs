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
        List<Producto> productosList = new List<Producto>(); // Creo una lista para guardar los productos añadidos al carrito

        public void cargarDatos()
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

        // Método para aplicar los filtros seleccionados
        private void buttonFiltrar_Click(object sender, EventArgs e)
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

        // Método para filtrar por precio
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

        
        // Método para filtrar por categoria
        private Boolean showCategoria(DataRow producto)
        {
            if (cmbCategoria.Text != producto["categoría"].ToString()) return false;
            return true;
        }

        // Método para filtrar por marca
        private Boolean showMarca(DataRow producto)
        {
            if (cmbMarca.Text != producto["marca"].ToString()) return false;
            return true;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonCarrito_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(productosList);
            f2.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Compruebo si hay algún producto seleccionado en la lista
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para añadir"); // Si no hay ningún producto seleccionado, muestro mensaje por dialog
                return; 
            }
            // Obtengo el producto seleccionado
            ListViewItem item = listView1.SelectedItems[0];

            // Creo un objeto de tipo Producto que tendrá los valores recodigos en item
            Producto producto = new Producto(
                item.SubItems[0].Text, // Id del producto
                item.SubItems[1].Text, // Nombre del componente
                decimal.Parse(item.SubItems[2].Text), // Precio
                item.SubItems[3].Text, // Marca
                item.SubItems[4].Text, // Categoria
                1                     // Cantidad inicial
                );

            // Agrego el producto a la lista 
            productosList.Add(producto);

            // Muestro un mensaje si el producto se ha añadido correctamente al carrito
            MessageBox.Show("Producto añadido correctamente");
        }
    }
}
