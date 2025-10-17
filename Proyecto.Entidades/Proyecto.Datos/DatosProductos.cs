using System;
using System.Collections.Generic;
using Proyecto.Entidades;

namespace Proyecto.Datos
{
   
    public class DatosProductos
    {
        // Lista en memoria que actúa como tabla de productos
        private static List<Producto> listaProductos = new List<Producto>();

        // Obtener todos los productos
        public List<Producto> ListarProductos()
        {
            return listaProductos;
        }

        // Agregar un nuevo producto
        public void AgregarProducto(Producto producto)
        {
            producto.IdProducto = listaProductos.Count + 1;
            listaProductos.Add(producto);
        }

        // Editar un producto existente
        public void EditarProducto(Producto productoActualizado)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].IdProducto == productoActualizado.IdProducto)
                {
                    listaProductos[i] = productoActualizado;
                    break;
                }
            }
        }

        // Eliminar un producto por ID
        public void EliminarProducto(int idProducto)
        {
            listaProductos.RemoveAll(p => p.IdProducto == idProducto);
        }

        // Buscar productos por código o nombre
        public List<Producto> BuscarProducto(string criterio)
        {
            criterio = criterio.ToLower();
            return listaProductos.FindAll(p =>
                p.Nombre.ToLower().Contains(criterio) ||
                p.Codigo.ToLower().Contains(criterio)
            );
        }
    }
}