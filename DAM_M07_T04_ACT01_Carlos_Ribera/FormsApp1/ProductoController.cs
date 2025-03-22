using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.Json;

namespace FormsApp1
{
    class ProductoController
    {
        // Ruta por defecto en la carpeta del proyecto
        private static string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exports");
        private static string filePath = Path.Combine(rutaCarpeta, "carrito.json");

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

        // Método para guardar List en JSON
        public static void GuardarProductos(List<Producto> productosList)
        {
            
            try{
                // Compruebo si el directorio existe
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta); // Si no existe, lo creo
                }

                // Serializo la lista de productos en formato JSON
                string json = JsonSerializer.Serialize(productosList);

                // Escribo el archivo JSON
                File.WriteAllText(filePath, json);

                // Confirmo que el archivo se ha guardado correctamente en la ruta
                MessageBox.Show("Carrito guardado correctamente" + filePath);
            }
            catch(Exception e){
                MessageBox.Show("Error al guardar el carrito: " + e.Message);
            }
        }

        // Método para cargar productos desde JSON a List
        public static List<Producto> CargarProductos(List<Producto> productosList)
        {
            Form1 form = new Form1();

            // Compruebo si el directorio existe
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
            // Compruebo si el archivo existe
            if (!File.Exists(filePath))
            {
                MessageBox.Show("No hay ninguna lista de productos guardada");
                return new List<Producto>(); // Retorno una lista vacía para evitar errores de nullPointException (en Java me pasaba amenudo)
            }
            // Leer el contenido del archivo JSON
            String json = File.ReadAllText(filePath);

            
            // Deserializar el contenido del JSON en una List
            return productosList = JsonSerializer.Deserialize<List<Producto>>(json);
            
        }
    }
}
