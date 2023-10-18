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
        public formincorrecto(string valorindice)
        {
            InitializeComponent();
            valorincorrecto = valorindice;
        }
        public int Interval { get; private set; }

        private void formincorrecto_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (valorincorrecto == "videollamada")
           {
                multiplechoice ventana = new multiplechoice("videollamada");
                ventana.Show();
                this.Close();
           }

           else if (valorincorrecto == "llamada")
            {
                multiplechoice ventana = new multiplechoice("llamada");
                ventana.Show();
                this.Close(); 

            }

            else if (valorincorrecto == "camara")
            {
                multiplechoice ventana = new multiplechoice("camara");
                ventana.Show();
                this.Close();

            }
            else if (valorincorrecto == "sticker")
            {
                multiplechoice ventana = new multiplechoice("sticker");
                ventana.Show();
                this.Close();

           }
            else if (valorincorrecto == "audio")
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
