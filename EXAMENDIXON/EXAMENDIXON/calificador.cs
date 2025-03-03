using System;
using System.Collections.Generic;
using System.Linq;

namespace EXAMENDIXON
{
    public class Calificador
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string dni;
        public int nota;
        public string calificacion { get; set; }

        public Calificador(string nombres, string apellidos, string dni, int nota)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
            this.nota = nota;
            calificacion = CalcularCalificacion(nota);
        }

        // Metodo publico que acepta un int
        public string CalcularCalificacion(int nota)
        {
            if (nota < 5)
            {
                return "SS";
            }
            else if (nota >= 5 && nota < 7)
            {
                return "AP";
            }
            else if (nota >= 7 && nota < 9)
            {
                return "NT";
            }
            else if (nota >= 9)
            {
                return "SB";
            }
            else
            {
                return "Nota no válida";
            }
        }
        //metodo string
        public override string ToString()
        {
            return $"Nombre: {nombres} {apellidos}, DNI: {dni}, Nota: {nota}, Calificación: {calificacion}";
        }

        

    }
}
