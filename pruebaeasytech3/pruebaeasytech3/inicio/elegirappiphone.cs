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
    public partial class elegirappiphone : Form
    {
        public elegirappiphone()
        {
            InitializeComponent();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            IND_instagram ventana = new IND_instagram();
            ventana.Show();
            this.Hide();
        }

        private void btnsiguiente1_Click(object sender, EventArgs e)
        {
            IND_whatsappiphone ventana = new IND_whatsappiphone();
            ventana.Show();
            this.Hide();
        }

        private void btnsiguiente2_Click(object sender, EventArgs e)
        {
            IN_configuracioniphone ventana = new IN_configuracioniphone();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seleccionar ventana = new seleccionar();
            ventana.Show();
            this.Hide();
        }
    }
}
