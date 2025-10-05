using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Entidades
{// Esta clase representa los datos de un empleado (para el CRUD)
    public class Empleado
    {
        // Propiedades o atributos del empleado
        public int IdEmpleado { get; set; }      // Identificador único del empleado
        public string Nombre { get; set; }       // Nombre completo
        public string Cargo { get; set; }        // Cargo o puesto en la empresa
        public string Telefono { get; set; }     // Número de contacto
        public string Correo { get; set; }       // Correo electrónico
        public bool Estado { get; set; }         // Activo o inactivo

        // Constructor vacío (para crear objetos sin datos iniciales)
        public Empleado() { }

        // Constructor con parámetros (para crear empleados con datos)
        public Empleado(int idEmpleado, string nombre, string cargo, string telefono, string correo, bool estado)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Cargo = cargo;
            Telefono = telefono;
            Correo = correo;
            Estado = estado;
        }
    }
}
