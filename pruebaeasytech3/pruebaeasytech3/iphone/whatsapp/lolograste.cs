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
    public partial class lolograste : Form
    {
        
        public lolograste()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                home ventana = new home();
                ventana.Show();
                this.Hide();
            

        }

        private void lolograste_Load(object sender, EventArgs e)
        {

        }
    }
}