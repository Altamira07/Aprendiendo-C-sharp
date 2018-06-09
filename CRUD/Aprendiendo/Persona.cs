using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo
{
    class Persona
    {

        String nombre { get; set; }
        int edad { get; set; }
        public Persona(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            
        }
        public override string ToString()
        {
            return "Nombre: "+nombre+"Edad: "+edad;
        }
    }
}
