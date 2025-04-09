using Microsoft.Reporting.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsApp1
{
    public partial class Form1: Form
    {
        // Lista global y estática para almacenar los productos añadidos al carrito
        DataTable productos;
        public static List<Producto> productosList = new List<Producto>();

        // Método para cargar los datos desde el DataSet y mostrarlos en el ListView
        public void cargarDatos()
        {
            productos = this.dataSet11.catalogo;
            listaPrincipal.Items.Clear();

            // Itero sobre la lista de productos y agrego cada fila al ListVew
            foreach(DataRow producto in productos.Rows)
            {
                ListViewItem item = listaPrincipal.Items.Add(producto["id"].ToString());
                item.SubItems.Add(producto["componente"].ToString());
                item.SubItems.Add(producto["precio"].ToString());
                item.SubItems.Add(producto["marca"].ToString());
                item.SubItems.Add(producto["categoría"].ToString());
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

        // Botón para aplicar los filtros seleccionados
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            productos = this.dataSet11.catalogo;
            listaPrincipal.Items.Clear();

            // Itero sobre la lista de productos para aplicar los filtros seleccionados
            foreach (DataRow producto in productos.Rows)
            {
                // Compruebo si el producto cumple con los filtros seleccionados
                if (!showCategoria(producto) || !showMarca(producto) || !showPrecio(producto)) continue;
                {
                    // Si pasa el filtro lo agrego a ListView
                    ListViewItem item = listaPrincipal.Items.Add(producto["id"].ToString());
                    item.SubItems.Add(producto["componente"].ToString());
                    item.SubItems.Add(producto["precio"].ToString());
                    item.SubItems.Add(producto["marca"].ToString());
                    item.SubItems.Add(producto["categoría"].ToString());
                }

            }
        }

        // Método para filtrar según el precio seleccionado en "cmbPrecio"
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

        // Botón para añadir producto seleccionado al carrito
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Compruebo si hay algun producto seleccionado en ListView
            if (listaPrincipal.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para añadir.");
                return;
            }

            // Obtengo el producto seleccionado
            ListViewItem item = listaPrincipal.SelectedItems[0];

            // Creo un objeto de tipo Producto con los datos obtenidos
            Producto producto = new Producto(
                item.SubItems[0].Text, // Id del producto
                item.SubItems[1].Text, // Nombre del componente
                decimal.Parse(item.SubItems[2].Text), // Precio
                item.SubItems[3].Text, // Marca
                item.SubItems[4].Text, // Categoria
                1                     // Cantidad inicial
                );
      
            // Añado el producto a la lista mediante el controlador
            ProductoController.addProducto(productosList, producto); 
            MessageBox.Show("Producto añadido al carrito");
        }

        // Botón para abrir el formulario del carrito
        private void buttonCarrito_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(productosList);
            f2.ShowDialog();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            productosList = ProductoController.CargarProductos(productosList);
            MessageBox.Show("Carrito cargado correctamente");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
