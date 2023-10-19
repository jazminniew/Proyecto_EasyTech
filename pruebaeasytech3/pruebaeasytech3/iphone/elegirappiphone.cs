using System;
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
    public partial class elegirappiphone : Form
    {
        string valorRecibido;
        public elegirappiphone(string valor)
        {
            InitializeComponent();
            valor = valorRecibido;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IND_whatsappiphone ventana = new IND_whatsappiphone();
            ventana.Show();
            this.Hide();

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            seleccionar ventana = new seleccionar();
            ventana.Show();
            this.Hide();
        }

        private void btncomenzar3_Click(object sender, EventArgs e)
        {
            IN_configuracioniphone ventana = new IN_configuracioniphone();
            ventana.Show();
            this.Hide();
           
        }

        private void btncomenzar_Click(object sender, EventArgs e)
        {
           
            IND_instagram ventana = new IND_instagram("instagramiphone");
            ventana.Show();
            this.Hide();
        }
    }
}
