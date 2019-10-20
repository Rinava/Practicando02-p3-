using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoEntidades
    {
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public string Nombres { get; set; }
        public double Promedio { get; set; }

        public AlumnoEntidades(string ap, int leg, string nom, double prom)
        {
            Apellido = ap;
            Legajo = leg;
            Nombres = nom;
            Promedio = prom;
        }

    }
}
