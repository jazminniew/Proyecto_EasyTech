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
    public partial class lolograste : Form
    {
        
        public lolograste()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                seleccionar ventana = new seleccionar();
                ventana.Show();
                this.Hide();
            

        }

        private void lolograste_Load(object sender, EventArgs e)
        {

        }

        private void btnvuelveaintentarlo_Click(object sender, EventArgs e)
        {
            Form f1 = Program.lastTryForm;
            f1.Show();
            Close();
        }
    }
}
