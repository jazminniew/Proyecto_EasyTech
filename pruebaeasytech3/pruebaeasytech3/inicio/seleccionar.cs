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
    public partial class seleccionar : Form
    {
        string valor;
        public seleccionar()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btnright1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == imageListiphone.Images.Count)
            {
                count = 0;
            }
            pcbiphone.Image = imageListiphone.Images[count];
        }

        private void btnleft1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count = imageListiphone.Images.Count-1;
            }
            else
            {
                count--;
            }
            pcbiphone.Image = imageListiphone.Images[count];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count == imageListandroid.Images.Count)
            {
                count = 0;
            }
            pcbandroid.Image = imageListandroid.Images[count];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count = imageListandroid.Images.Count - 1;
            }
            else
            {
                count--;
            }
            pcbandroid.Image = imageListandroid.Images[count];
        }

        private void btnsiguienteiphone_Click(object sender, EventArgs e)
        {
            
            elegirappiphone ventana = new elegirappiphone(valor);
            ventana.Show();
            this.Hide();
        }

        private void btnsiguienteandroid_Click(object sender, EventArgs e)
        {
            
            elegirappandroid ventana = new elegirappandroid();
            ventana.Show();
            this.Hide();
        }

        private void seleccionar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayuda ventana = new ayuda();
            ventana.Show();
            this.Hide();
        }

        private void pcbandroid_Click(object sender, EventArgs e)
        {

        }
    }
}
