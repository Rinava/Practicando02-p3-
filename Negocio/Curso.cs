using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Curso
    {
        public static List<AlumnoEntidades> RecuperarAlumnos()
        {
            AlumnoDatos alu = new AlumnoDatos(); 
            return alu.GenerarAlumnos();
        }
    }
}
