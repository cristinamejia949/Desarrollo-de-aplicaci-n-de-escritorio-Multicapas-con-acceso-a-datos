using System;
using System.Collections.Generic;
using Proyecto.Entidades;

namespace Proyecto.Datos
{
   
    public class DatosClientes
    {
        // Lista para guardar los clientes en memoria 
        private static List<Cliente> listaClientes = new List<Cliente>();

        // Método para obtener todos los clientes
        public List<Cliente> ListarClientes()
        {
            return listaClientes;
        }

        // Método para agregar un nuevo cliente
        public void AgregarCliente(Cliente cliente)
        {
            cliente.IdCliente = listaClientes.Count + 1; // asignar ID automático
            listaClientes.Add(cliente);
        }

        // Método para actualizar un cliente existente
        public void EditarCliente(Cliente clienteActualizado)
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].IdCliente == clienteActualizado.IdCliente)
                {
                    listaClientes[i] = clienteActualizado;
                    break;
                }
            }
        }

        // Método para eliminar un cliente por ID
        public void EliminarCliente(int idCliente)
        {
            listaClientes.RemoveAll(c => c.IdCliente == idCliente);
        }

        // Método para buscar clientes por nombre o documento
        public List<Cliente> BuscarCliente(string criterio)
        {
            criterio = criterio.ToLower();
            return listaClientes.FindAll(c =>
                c.Nombre.ToLower().Contains(criterio) ||
                c.Documento.ToLower().Contains(criterio)
            );
        }
    }
}
