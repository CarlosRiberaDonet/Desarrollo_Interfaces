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
                listViewCarrito.Items.Add(item);

                importeTotal = importeTotal + (producto.precio * producto.cantidad);
                textBoxImporte.Text = importeTotal.ToString("0.00");
            }
        }
    }
}
