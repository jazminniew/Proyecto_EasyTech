using System;
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
    public partial class elegirappandroid : Form
    {
        public elegirappandroid()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            seleccionar ventana = new seleccionar();
            ventana.Show();
            this.Hide();
        }

        private void btncomenzar2_Click(object sender, EventArgs e)
        {
            IN_whatsappandroid ventana = new IN_whatsappandroid();
            ventana.Show();
            this.Hide();
        }


        private void btncomenzar3_Click(object sender, EventArgs e)
        {
            IN_configuracionandroid ventana = new IN_configuracionandroid();
            ventana.Show();
            this.Hide();
        }

        private void btncomenzar_Click(object sender, EventArgs e)
        {
            IND_instagram ventana = new IND_instagram("");
            ventana.Show();
            this.Hide();
        }
    }
}
