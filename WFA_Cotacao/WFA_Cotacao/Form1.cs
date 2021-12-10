using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA_Cotacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Cotacao cot;
            cot = new Cotacao(double.Parse(txtVED.Text), double.Parse(txtVDD.Text));
            cot.converter();
            txtVER.Text = cot.getValorEmReal().ToString();
        }
    }
}
