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
        public string valorcorrecto;
        public formincorrecto(string valorindice)
        {
            InitializeComponent();
            valorcorrecto = valorindice;
        }

        private void formincorrecto_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (valorcorrecto == "videollamada")
           {
                multiplechoice ventana = new multiplechoice("videollamada");
                ventana.Show();
                this.Close();
           }

           else if (valorcorrecto == "llamada")
            {
                multiplechoice ventana = new multiplechoice("llamada");
                ventana.Show();
                this.Close(); 

            }

            else if (valorcorrecto == "camara")
            {
                multiplechoice ventana = new multiplechoice("camara");
                ventana.Show();
                this.Close();

            }
            else if (valorcorrecto == "sticker")
            {
                multiplechoice ventana = new multiplechoice("sticker");
                ventana.Show();
                this.Close();

           }
            else if (valorcorrecto == "audio")
            {
                multiplechoice ventana = new multiplechoice("audio");
                ventana.Show();
                this.Close();

            }
            else
            {
                multiplechoice ventana = new multiplechoice("audio");
                ventana.Show();
                this.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
