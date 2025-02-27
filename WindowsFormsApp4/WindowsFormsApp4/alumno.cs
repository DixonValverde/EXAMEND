using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class alumno
    {   //contructor de los datos
        public string nombre;
        public string apellido;
        public string dni;
        public int nota;
        public String calificacion;
        //llamar construcotres
        public alumno(string nombre, string apellido,string dni, int nota)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nota = nota;
            calcularcalificacion();
        }//calcular la calificacion 
        public void calcularcalificacion()
        {
            if (nota < 5) calificacion = "SS";
            else if (nota < 7) calificacion = "AP";
            else if (nota < 9) calificacion = "nt";
            else calificacion = "SB";
        }
        //modificacion de nota
        public void modinota(int nuevanota)
        {
            nota = nuevanota;
            calcularcalificacion();
        }
        //llamar las variables
        public override string ToString()
        {
            return $"{nombre} {apellido} {dni}{nota}{calificacion}";
        }





    }
        
            
}
