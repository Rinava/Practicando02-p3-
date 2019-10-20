using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class AlumnoDatos
    {
       public List<Entidades.AlumnoEntidades> GenerarAlumnos ()
        {
            List<Entidades.AlumnoEntidades> alu = new List<Entidades.AlumnoEntidades>();
            alu.Add(new Entidades.AlumnoEntidades( "Burgardt", 41168, "Germán", 8.5));
            alu.Add(new Entidades.AlumnoEntidades( "Marmol", 42154, "Pedro", 7.5));
            alu.Add(new Entidades.AlumnoEntidades( "José", 41168, "Gimenes", 10.0));
            return alu;
        }
        
        
        
    }
}
