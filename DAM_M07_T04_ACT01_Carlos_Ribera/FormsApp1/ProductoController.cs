using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    class ProductoController
    {
        
        // Método para añadir productos
        public static List<Producto> addProducto(List<Producto> productosList, Producto producto)
        {

            // Itero sobre productosList para ver si el producto ya está añadido
            foreach(Producto p in productosList)
            {
                if (p.id == producto.id)
                {
                    p.cantidad++; // Incremento la cantidad
                    return productosList; // Devuelvo la lista actualizada con la nueva cantidad
                }
            }
            // Si el producto no está en la lista, lo añado
            productosList.Add(producto);
            return productosList; // Devuelvo la lista actualizada con la cantidad modificada
        }


        // Método para eliminar productos
        public static List<Producto> delProducto(List<Producto> productosList, Producto producto)
        {
            // Itero sobre productosList
            foreach (Producto p in productosList)
            {
                if (p.id == producto.id) // Si el id ya está en productosList
                {
                    // Si la cantidad es 1, lo elimino
                    if (p.cantidad == 1)
                    {
                        productosList.Remove(p);
                        return productosList;// Retorno la lista modificada
                    }
                    else
                    {
                        // Si cantidad es mayor que 1, le resto 1
                        p.cantidad--;
                        return productosList;// Retorno la lista modificada
                    }    
                }
            }
            return null; // Si no se encuentra el producto, retorno null
        }
    }
}
