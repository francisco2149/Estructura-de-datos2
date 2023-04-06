using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_datos2
{
    public partial class DatosProgramador : Form
    {
        public DatosProgramador()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LblDivision.Text = "       A       ";
            LblNombre.Text = "Francisco Sanchez";
            LblProfesor.Text = "Erica";
            LblMateria.Text = "Estructura de datos";
        }
    }
}
