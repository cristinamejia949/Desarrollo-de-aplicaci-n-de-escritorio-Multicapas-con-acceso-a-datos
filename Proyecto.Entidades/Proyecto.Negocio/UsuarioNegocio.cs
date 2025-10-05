using System;
using Proyecto.Entidades;
using Proyecto.Datos;

namespace Proyecto.Negocio
{
    // Esta clase contiene la lógica del negocio para el manejo de usuarios
    // Usuario de prueba: admin
    // Contraseña de prueba: 1234
    public class UsuarioNegocio
    {
        // Este método simula una validación de inicio de sesión 
        public bool ValidarLogin(string nombreUsuario, string contrasena)
        {
           
            if (nombreUsuario == "admin" && contrasena == "1234")
            {
                return true; // acceso concedido
            }

            // Si no coincide, denegamos acceso
            return false;
        }

        // Método de ejemplo para crear usuario 
        public string CrearUsuario(Usuario nuevoUsuario)
        {
            // Validar campos básicos
            if (string.IsNullOrEmpty(nuevoUsuario.NombreUsuario) || string.IsNullOrEmpty(nuevoUsuario.Contrasena))
            {
                return "Debe ingresar usuario y contraseña.";
            }

            // Simulamos guardarlo (en una base real iría aquí la lógica de inserción)
            return $"Usuario '{nuevoUsuario.NombreUsuario}' registrado correctamente (simulado).";
        }
    }
}
