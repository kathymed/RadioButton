﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRadioButton2
{
    public partial class lblResultado : Form
    {
        public lblResultado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numero1, numero2, suma, resta;
            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);
            if (rdSuma.Checked == true)
            {
                suma = numero1 + numero2;
                txtResultado.Text = suma.ToString();
            }
            else
            {
                resta = numero1 - numero2;
                txtResultado.Text = resta.ToString();
            }
        }
    }
}
