using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Examenbo
{
    internal class Crud_calificaciones
    {
        private static List<Alumno> alumnos = new List<Alumno>();

        // Método para obtener la lista de alumnos
        public static List<Alumno> ObtenerAlumnos()
        {
            return alumnos;
        }

        // Método para agregar alumnos a la lista
        public static void AgregarAlumno(Alumno alumno)
        {
            if (existeAlumno(alumno.DNI))
            {
                MessageBox.Show("El alumno ya existe en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            alumnos.Add(alumno);
            MessageBox.Show("Alumno agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Verifica si un alumno existe por su DNI
        public static bool existeAlumno(string dniAlumno)
        {
            return alumnos.Any(alumno => alumno.DNI == dniAlumno);
        }

        // Buscar y mostrar datos del alumno con MessageBox
        public static void buscarAlumnoPorDNI(string dniAlumno)
        {
            Alumno alumno = alumnos.Find(a => a.DNI == dniAlumno);
            if (alumno == null)
            {
                MessageBox.Show("El alumno no existe.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"DNI: {alumno.DNI}\n" +
                                $"Apellido: {alumno.Apellido}\n" +
                                $"Nombre: {alumno.Nombre}\n" +
                                $"Nota: {alumno.Nota}\n" +
                                $"Calificación: {alumno.Calificacion}",
                                "Datos del Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Obtener un alumno por su DNI 
        public static Alumno ObtenerAlumno(string dni)
        {
            return alumnos.Find(a => a.DNI == dni);
        }

        //Eliminar un alumno por su DNI
        public static void EliminarAlumno(string dni)
        {
            Alumno alumno = ObtenerAlumno(dni);
            if (alumno != null)
            {
                alumnos.Remove(alumno);
                MessageBox.Show("Alumno eliminado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el alumno para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


