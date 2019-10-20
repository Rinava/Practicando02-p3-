using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;


namespace Practicando02
{
    public partial class AlumnoListado : Form
    {
        public AlumnoListado()
        {
            InitializeComponent();
            CargarGrilla();
        }
        public void CargarGrilla()
        {
            
            dgvListado.DataSource = Curso.RecuperarAlumnos();
        }
    }
}
