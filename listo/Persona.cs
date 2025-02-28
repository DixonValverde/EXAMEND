using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenbo
{
    internal class Persona
    {
        //definicion atributos
        public String DNI { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        
        public Persona(String dni, String nombre, String apellido)
        { //constructor
            //inicializar variables
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            
        }



    }
}
