using System;
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
    public partial class Form2 : Form
    {
        private List<Producto> productosList = new List<Producto>();
        private decimal importeTotal = 0;

        public Form2(List<Producto> productos)
        {
            InitializeComponent();
            productosList = productos;
            MostrarProductos(); 
        }

        // Método para mostrar los productos
        private void MostrarProductos()
        {
            listaCarrito.Items.Clear();
            foreach (Producto producto in productosList)
            {

                // Creo un producto en la lista con el ID del producto
                ListViewItem item = new ListViewItem(producto.id.ToString());
                item.SubItems.Add(producto.name.ToString());
                item.SubItems.Add(producto.precio.ToString());
                item.SubItems.Add(producto.marca.ToString());
                item.SubItems.Add(producto.categoria.ToString());
                item.SubItems.Add(producto.cantidad.ToString());

                // Añado el producto creado al listView
                listaCarrito.Items.Add(item);
                // Calculo el valor del importe total
                importeTotal = CalularImporte(productosList);
                textBoxImporte.Text = importeTotal.ToString("0.00");
            }
        }

        
        

        // Método para calcular el importe total de los productos del carrito
        public decimal CalularImporte(List<Producto> productosList)
        {
            decimal importeTotal = 0;
            foreach (Producto p in productosList)
            {
                importeTotal += (p.cantidad * p.precio);
            }   
            return importeTotal;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Obtengo el producto seleccionado en el ListView
            if (listaCarrito.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para añadir.");
                return;
            }

            // Obtengo el producto seleccionado
            ListViewItem item = listaCarrito.SelectedItems[0];

            // Creo un objeto de tipo Producto que tendrá los valores recodigos en item
            Producto producto = new Producto(
                item.SubItems[0].Text, // Id del producto
                item.SubItems[1].Text, // Nombre del componente
                decimal.Parse(item.SubItems[2].Text), // Precio
                item.SubItems[3].Text, // Marca
                item.SubItems[4].Text, // Categoria
                int.Parse(item.SubItems[5].Text ) // Cantidad
                );

            // Llamo a addProducto de la clase ProductoController
            ProductoController.addProducto(productosList, producto);

            importeTotal = CalularImporte(productosList);
            // LLamo a MostrarProductos para actualizar la lista
            MostrarProductos();
            MessageBox.Show("Producto añadido al carrito");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Obtengo el producto seleccionado en el ListView
            if (listaCarrito.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar de la lista");
                return;
            }

            // Obtengo el producto seleccionado
            ListViewItem item = listaCarrito.SelectedItems[0];

            // Creo un objeto de tipo Producto que tendrá los valores recodigos en item
            Producto producto = new Producto(
                item.SubItems[0].Text, // Id del producto
                item.SubItems[1].Text, // Nombre del componente
                decimal.Parse(item.SubItems[2].Text), // Precio
                item.SubItems[3].Text, // Marca
                item.SubItems[4].Text, // Categoria
                int.Parse(item.SubItems[5].Text) // Cantidad
                );

            // Llamo a addProducto de la clase ProductoController
            ProductoController.delProducto(productosList, producto);
            importeTotal = CalularImporte(productosList);
            // LLamo a MostrarProductos para actualizar la lista
            MostrarProductos();
            
            MessageBox.Show("Producto eliminado al carrito");
        }

        // Botón para eliminar producto del carrito



        // Método para actualizar la columna cantidad en tiempo real
        /* private void ActualizarCarrito(String id, int cantidad)
         {
             foreach (ListViewItem item in listaCarrito.Items)
             {
                 // Si el ID del producto coincide, actualiza la cantidad
                 if (item.SubItems[0].Text == id)
                 {
                     int nuevaCantidad = int.Parse(item.SubItems[5].Text) + 1;
                     item.SubItems[5].Text = nuevaCantidad.ToString();
                     break;
                 }
             }
         }*/
    }
}
