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
    public partial class IN_configuracioniphone : Form
    {
        public IN_configuracioniphone()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            elegirappiphone ventana = new elegirappiphone("");
            ventana.Show();
            this.Hide();
        }
    }
}
