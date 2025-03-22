using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FormsApp1
{
    public class Producto
    {
        public String id {  get; set; }
        public String name { get; set; }
        public decimal precio { get; set; }
        public string marca { get; set; }
        public string categoria { get; set; }
        public int cantidad { get; set; }

        // CONSTRUCTOR
        public Producto(String id, String name, decimal precio, String marca, String categoria, int cantidad)
        {
            this.id = id;
            this.name = name;
            this.precio = precio;
            this.marca = marca;
            this.categoria = categoria;
            this.cantidad = cantidad;
        }

        // Constructor vacío, lo utilizo para la deserialización
        public Producto()
        {
            
        }
    }
}
