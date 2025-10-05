using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Entidades
{// Esta clase representa los datos básicos del usuario del sistema (login, rol, etc.)
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
        public bool Estado { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, string nombreUsuario, string clave, string rol, bool estado)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Clave = clave;
            Rol = rol;
            Estado = estado;
        }
    }
}
