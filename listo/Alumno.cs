using System;

namespace Examenotro
{
    internal class Alumno : Persona
    {
        // Hacemos atributos requeridos
        public int Nota { get; set; }
        public string Calificacion { get; private set; } 

        // Constructor alumno que llamara alos demas
        public Alumno(string dni, string apellido, string nombre, int nota) : base (dni, apellido, nombre)
        {
            Nota = nota; //iniciar atributos
            asignarCalificacion();
        }

        private void asignarCalificacion()
        {
            if (Nota < 5)
            {
                Calificacion = "SS";
            }
            else if (Nota >= 5 && Nota < 7)
            {
                Calificacion = "AP";
            }
            else if (Nota >= 7 && Nota < 9)
            {
                Calificacion = "NT";
            }
            else
            {
                Calificacion = "SB";
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Nota: {Nota} - Calificación: {Calificacion}";
        }
    }
}

