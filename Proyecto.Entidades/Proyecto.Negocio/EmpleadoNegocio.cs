using System;
using System.Collections.Generic;
using Proyecto.Entidades;

namespace Proyecto.Negocio
{
    // Esta clase manejará la lógica del CRUD de empleados
    public class EmpleadoNegocio
    {
        // Lista estática para simular una base de datos
        private static List<Empleado> listaEmpleados = new List<Empleado>();

        // Crear empleado
        public string AgregarEmpleado(Empleado empleado)
        {
            listaEmpleados.Add(empleado);
            return $"Empleado {empleado.Nombre} agregado correctamente (simulado).";
        }

        // Leer empleados
        public List<Empleado> ObtenerEmpleados()
        {
            return listaEmpleados;
        }

        // Actualizar empleado
        public string ActualizarEmpleado(int id, string nuevoNombre, string nuevoCargo)
        {
            var emp = listaEmpleados.Find(e => e.Id == id);
            if (emp != null)
            {
                emp.Nombre = nuevoNombre;
                emp.Cargo = nuevoCargo;
                return $"Empleado {id} actualizado (simulado).";
            }
            return $"Empleado {id} no encontrado.";
        }

        // Eliminar empleado
        public string EliminarEmpleado(int id)
        {
            var emp = listaEmpleados.Find(e => e.Id == id);
            if (emp != null)
            {
                listaEmpleados.Remove(emp);
                return $"Empleado {id} eliminado (simulado).";
            }
            return $"Empleado {id} no existe.";
        }
    }
}
