using System;
using System.Collections.Generic;
using Proyecto.Entidades;
using Proyecto.Datos;

namespace Proyecto.Negocio
{

    // Se hacen validaciones antes de enviar o recibir datos de la capa de Datos
    public class NegocioClientes
    {
        // Instancia de la clase de datos
        private DatosClientes datos = new DatosClientes();

        //  Listar todos los clientes
        public List<Cliente> Listar()
        {
            return datos.ListarClientes();
        }

        // Agregar un nuevo cliente
        public string Agregar(Cliente cliente)
        {
            // Validaciones básicas antes de guardar
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                return "El nombre del cliente es obligatorio.";

            if (string.IsNullOrWhiteSpace(cliente.Documento))
                return "El documento del cliente es obligatorio.";

            if (!cliente.Correo.Contains("@"))
                return "El correo ingresado no es válido.";

            // Si pasa las validaciones, agregarlo a la lista
            datos.AgregarCliente(cliente);
            return "Cliente agregado correctamente.";
        }

        // Editar un cliente existente
        public string Editar(Cliente cliente)
        {
            if (cliente.IdCliente <= 0)
                return "ID de cliente inválido.";

            datos.EditarCliente(cliente);
            return "Cliente actualizado correctamente.";
        }

        // Eliminar un cliente por su ID
        public string Eliminar(int idCliente)
        {
            if (idCliente <= 0)
                return "ID de cliente inválido.";

            datos.EliminarCliente(idCliente);
            return "Cliente eliminado correctamente.";
        }

        // Buscar clientes por nombre o documento
        public List<Cliente> Buscar(string criterio)
        {
            return datos.BuscarCliente(criterio);
        }
    }
}
