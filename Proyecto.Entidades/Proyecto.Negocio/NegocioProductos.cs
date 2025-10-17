using System;
using System.Collections.Generic;
using Proyecto.Entidades;
using Proyecto.Datos;

namespace Proyecto.Negocio
{
   
    public class NegocioProductos
    {
        private DatosProductos datos = new DatosProductos();

        // Listar productos
        public List<Producto> Listar()
        {
            return datos.ListarProductos();
        }

        // Agregar producto con validaciones
        public string Agregar(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                return "El nombre del producto es obligatorio.";

            if (producto.Precio <= 0)
                return "El precio debe ser mayor a 0.";

            if (producto.Stock < 0)
                return "El stock no puede ser negativo.";

            datos.AgregarProducto(producto);
            return "Producto agregado correctamente.";
        }

        // Editar producto
        public string Editar(Producto producto)
        {
            if (producto.IdProducto <= 0)
                return "ID del producto inválido.";

            datos.EditarProducto(producto);
            return "Producto actualizado correctamente.";
        }

        // Eliminar producto
        public string Eliminar(int idProducto)
        {
            if (idProducto <= 0)
                return "ID inválido.";

            datos.EliminarProducto(idProducto);
            return "Producto eliminado correctamente.";
        }

        // Buscar producto
        public List<Producto> Buscar(string criterio)
        {
            return datos.BuscarProducto(criterio);
        }
    }
}
