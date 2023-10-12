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
    public partial class eligefondo : Form
    {
        string valorRecibido;
        public eligefondo(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "FONDOPANTALLA1")
            {
                string valor = "FONDOPANTALLA22"; 
                formcorrecto ventana = new formcorrecto("FONDOPANTALLA22");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("FONDOPANTALLA22");
                ventana.Show();
                this.Hide();
            }

        }

        private void eligefondo_Load(object sender, EventArgs e)
        {

        }
    }
}
