using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA_Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            Triangulo tri;
            tri = new Triangulo(int.Parse(txtLado1.Text),
                                int.Parse(txtLado2.Text),
                                int.Parse(txtLado3.Text));
            tri.classificar();
            lblTipo.Text = tri.getTipo().ToString();
            lblTipo2.Text = (tri.getTipo() == 1 ? "Equilátero" :
                tri.getTipo() == 2 ? "Isósceles" : "Escaleno");

            radEquilatero.Checked = (tri.getTipo() == 1);
            radIsosceles.Checked = (tri.getTipo() == 2);
            radEscaleno.Checked = (tri.getTipo() == 3);

            if (tri.getTipo()==1)
               picTriangulo.Image = WFA_Triangulos.Properties.Resources.equilatero;
            if (tri.getTipo() == 2)
                picTriangulo.Image = WFA_Triangulos.Properties.Resources.isosceles;
            if (tri.getTipo() == 3)
                picTriangulo.Image = WFA_Triangulos.Properties.Resources.escaleno;
        }
    }
}
