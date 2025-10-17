using System;

namespace Proyecto.Entidades
{
    //Clase que representa un producto en el sistema
    public class Producto
    {
        // Identificador único del producto
        public int IdProducto { get; set; }

        // Código del producto (por ejemplo REF123)
        public string Codigo { get; set; }

        // Nombre o descripción corta del producto
        public string Nombre { get; set; }

        // Precio de venta
        public decimal Precio { get; set; }

        // Cantidad disponible en inventario
        public int Stock { get; set; }

        // Estado (activo o inactivo)
        public bool Activo { get; set; }

        // Constructor vacío
        public Producto() { }

        // Constructor con parámetros
        public Producto(int id, string codigo, string nombre, decimal precio, int stock, bool activo)
        {
            IdProducto = id;
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Activo = activo;
        }
    }
}
