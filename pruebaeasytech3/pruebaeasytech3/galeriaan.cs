﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaeasytech3
{

  
    public partial class galeriaan : Form
    {
        string valorRecibido;
        public galeriaan(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void btnfotos_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "GALERIAAN")
            {
                string valor = "GALERIAAAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
