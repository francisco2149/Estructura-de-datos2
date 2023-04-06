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
    public partial class Estructura_dinamica_lineal : Form
    {
        Cola x = new Cola();
        Nodo z = new Nodo();
        public Estructura_dinamica_lineal()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            z.Codigo = Convert.ToInt32(TxtCodigo.Text);
            z.Nombre = TxtNombre.Text;
            z.Tramite = TxtTramite.Text;

        }
    }
}
