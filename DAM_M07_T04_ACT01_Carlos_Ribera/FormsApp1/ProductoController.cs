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
        
        // Método para añadir productos en productosList (carrito)
        public static List<Producto> addProducto(List<Producto> productosList, Producto producto)
        {

            // Itero sobre productosList para ver si el producto ya está añadido
            foreach(Producto p in productosList)
            {
                if (p.id == producto.id)
                {
                    p.cantidad++;
                    return productosList; // Devuelvo la lista actualizada con la nueva cantidad
                }
            }
            productosList.Add(producto);
            return productosList; // Devuelvo la lista actualizada con el nuevo producto
        }


        // Método para comprobar si el producto ya esta en productosList
        public static List<Producto> delProducto(List<Producto> productosList, Producto producto)
        {
            // Itero sobre productosList
            foreach (Producto p in productosList)
            {
                if (p.id == producto.id) // Si el id ya está en productosList
                {
                    if (p.cantidad == 1)
                    {
                        productosList.Remove(p);
                        return productosList;// Retorno la lista modificada
                    }
                    else
                    {
                        p.cantidad--;
                        return productosList;// Retorno la lista modificada
                    }
                    
                }
            }
            return null;
        }
    }
}
