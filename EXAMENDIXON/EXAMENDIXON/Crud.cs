using System;
using System.Collections.Generic;
using System.Linq;

namespace EXAMENDIXON
{
    public class GestionCalificador
    {
        public List<Calificador> calificadores = new List<Calificador>();

        //Agrego un nuevo calificador
        public void CrearCalificador(string nombres, string apellidos, string dni, int nota)
        {
            Calificador nuevo = new Calificador(nombres, apellidos, dni, nota);
            calificadores.Add(nuevo);
            Console.WriteLine("Calificador creado exitosamente.");
        }

        //Leer todas los calificadores
        public void LeerTodos()
        {
            if (calificadores.Count == 0)
            {
                Console.WriteLine("No hay calificadores registrados.");
                return;
            }

            foreach (var calificador in calificadores)
            {
                Console.WriteLine(calificador.ToString());
            }
        }

        // Buscar un calificador por el dni
        public Calificador LeerPorDni(string dni)
        {
            Calificador encontrado = calificadores.Find(c => c.dni == dni);
            if (encontrado == null)
            {
                Console.WriteLine($"No se encontró un calificador con DNI: {dni}");
            }
            return encontrado;
        }

        //Solo modificar la nota por DNI
        public void ActualizarCalificador(string dni, int nota)
        {
            Calificador calificador = LeerPorDni(dni);
            if (calificador != null)
            {
                calificador.nota = nota;
                calificador.calificacion = calificador.CalcularCalificacion(nota);
                Console.WriteLine("Nota actualizada exitosamente.");
            }
        }

        // Eliminar un calificador por dni
        public void EliminarCalificador(string dni)
        {
            Calificador calificador = LeerPorDni(dni);
            if (calificador != null)
            {
                calificadores.Remove(calificador);
                Console.WriteLine("Calificador eliminado exitosamente.");
            }
        }
        public List<Calificador> listaCalificadores = new List<Calificador>();
        //para llamar si el dni ya esta registrado 
        public bool DniExiste(string dni)
        {
            return listaCalificadores.Any(info => info.dni == dni);
        }
        //metodo para llamar las calificaciones
        public List<Calificador> ObtenerCalificadores()
        {
            return calificadores;
        }
    }
}
