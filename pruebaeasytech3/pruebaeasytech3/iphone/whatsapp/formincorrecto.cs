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
    public partial class formincorrecto : Form
    {
        public string valorincorrecto;
        public formincorrecto(string valor)//de donde viene valor indice?
        {
            InitializeComponent();
            valorincorrecto = valor;
        }

        private void formincorrecto_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (valorincorrecto == "videollamada")
           {
                multiplechoice ventana = new multiplechoice("videollamada");
                ventana.Show();
                this.Hide();
           }

           else if (valorincorrecto == "llamada")
            {
                multiplechoice ventana = new multiplechoice("llamada");
                ventana.Show();
                this.Hide(); //si yo pongo aca que habra multiple choice porque no habre?

            }

            else if (valorincorrecto == "camara")
            {
                multiplechoice ventana = new multiplechoice("llamada");
                ventana.Show();
                this.Hide();

            }
            else if (valorincorrecto == "sticker")
            {
                multiplechoice ventana = new multiplechoice("sticker");
                ventana.Show();
                this.Hide();

            }
            else if (valorincorrecto == "audio")
            {
                multiplechoice ventana = new multiplechoice("audio");
                ventana.Show();
                this.Hide();

            }
            else
            {
                Form f1 = new home();
                f1.Show();
                this.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
