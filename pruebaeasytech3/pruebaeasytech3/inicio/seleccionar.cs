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
    public partial class seleccionar : Form
    {
        string valor;
        public seleccionar()
        {
            InitializeComponent();
        }
        int count = -1;
        private void btnright1_Click(object sender, EventArgs e)
        {
            if(count < 25)
            {
                count++;
            }            
            pcbiphone.Image = imageListiphone.Images[count]; //HAY UN ERROR PORQUE CUANDO SE TERMINAN LAS FOTOS NO VUELVE A EMPEZAR Y SE CIERRA
        }

        private void btnleft1_Click(object sender, EventArgs e)
        {
            if(count > 0)
            {
                count--;
            }
            pcbiphone.Image = imageListiphone.Images[count];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count < 25)
            {
                count++;
            }
            pcbandroid.Image = imageListiphone.Images[count];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            pcbandroid.Image = imageListiphone.Images[count];
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
    }
}
