﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_TIC_3RO
{
    
    public partial class IND_instagram : Form
    {
        string valorRecibido;
        public IND_instagram(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnlike_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "instagramiphone") { 

            elegirappiphone ventana = new elegirappiphone("");
            ventana.Show();
            this.Hide();
        }
            else
            {
                elegirappandroid ventana = new elegirappandroid();
                ventana.Show();
                this.Hide();
            }
        }
    }
}
