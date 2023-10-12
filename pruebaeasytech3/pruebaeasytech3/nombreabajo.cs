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
    public partial class nombreabajo : Form
    {
        string valorRecibido;
        public nombreabajo(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "Destacadosan")
            {
                string valor = "DESTACADOSAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("DESTACADOSAN");
                ventana.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "VACIARAN")
            {
                string valor = "VACIARANN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("VACIARANN");
                ventana.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "BLOQUEARAN")
            {
                string valor = "BLOQUEARANN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("BLOQUEARANN");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
