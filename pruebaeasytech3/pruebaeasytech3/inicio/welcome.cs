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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            seleccionar ventana = new seleccionar();
            ventana.Show();
            this.Hide();

        }
    }
}
