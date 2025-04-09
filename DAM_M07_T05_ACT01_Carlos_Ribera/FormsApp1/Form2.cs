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
        // Lista de productos añadidos al carrito
        private List<Producto> productosList = new List<Producto>();

        // Variable para almacenar el importe total del carrito
        private decimal importeTotal;

        // Constructor de Form2 que recibe la lista de productos del carrito
        public Form2(List<Producto> productos)
        {   
            InitializeComponent();
            productosList = productos;
            MostrarProductos(); // Muestra los productos al cargar el formulario
        }

        // Método para mostrar los productos
        private void MostrarProductos()
        {
            
            listaCarrito.Items.Clear();
            // Inicializo el importe total en 0
            importeTotal = 0;

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
            }
            // Creo esta condición porque no sabía como soluciona un error. Cuando eliminaba el último producto del carrito,
            // se quedaba guardado el último importe en el textBoxImporte
            if (productosList.Count == 0)
            {
                importeTotal = 0;
                textBoxImporte.Text = "0.00";
            }
            else
            {
                // Calculo el valor del importe total
                importeTotal = CalcularImporte(productosList);
                textBoxImporte.Text = importeTotal.ToString("0.00");
            }
        }

        // Método para calcular el importe total de los productos del carrito
        public decimal CalcularImporte(List<Producto> productosList)
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
            // LLamo a MostrarProductos para actualizar la lista
            MostrarProductos();
            
            MessageBox.Show("Producto eliminado al carrito");
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirigiendo a la pasarela de pago");
            ProductoController.GuardarProductos(productosList);
        }
    }
}
