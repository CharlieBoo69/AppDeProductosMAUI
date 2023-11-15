using PracticaMauiApp.Models;
using System.Collections.Generic;

namespace PracticaMauiApp.Utils
{
    public class Utils
    {
        // Utiliza la lista de productos establecida en lugar de generar aleatoriamente
        public static List<Producto> ListaProducto = new List<Producto>
        {
            new Producto
            {
                IdProducto = 1,
                Nombre = "Producto 1",
                Descripcion = "Descripción 1",
                Cantidad = 1
            },
            new Producto
            {
                IdProducto = 2,
                Nombre = "Producto 2",
                Descripcion = "Descripción 2",
                Cantidad = 2
            }
        };
    }
}
