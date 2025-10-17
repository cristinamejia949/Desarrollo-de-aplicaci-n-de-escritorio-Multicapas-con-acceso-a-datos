using System;

namespace Proyecto.Entidades
{
    // Clase que representa a un cliente dentro del sistema
    public class Cliente
    {
        // Identificador único del cliente
        public int IdCliente { get; set; }

        // Nombre completo del cliente
        public string Nombre { get; set; }

        // Documento de identidad
        public string Documento { get; set; }

        // Dirección física del cliente
        public string Direccion { get; set; }

        // Teléfono de contacto
        public string Telefono { get; set; }

        // Correo electrónico del cliente
        public string Correo { get; set; }

        // Estado (activo o inactivo)
        public bool Activo { get; set; }

        // Constructor vacío
        public Cliente() { }

        // Constructor con parámetros para crear clientes fácilmente
        public Cliente(int id, string nombre, string documento, string direccion, string telefono, string correo, bool activo)
        {
            IdCliente = id;
            Nombre = nombre;
            Documento = documento;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            Activo = activo;
        }
    }
}
