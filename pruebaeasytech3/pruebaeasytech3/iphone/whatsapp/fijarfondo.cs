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
    public partial class fijarfondo : Form
    {
        string valorRecibido;
        public fijarfondo(string valor)
        {
            InitializeComponent();
            valor = valorRecibido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "FONDOPANTALLA4")
            {
                string valor = "FONDOPANTALLA5";
                formcorrecto ventana = new formcorrecto("FONDOPANTALLA5");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("FONDIPANTALLA5");
                ventana.Show();
                this.Hide();
            }
        }

        private void fijarfondo_Load(object sender, EventArgs e)
        {

        }
    }
}
