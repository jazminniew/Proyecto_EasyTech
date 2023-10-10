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
    public partial class clip : Form
    {
        string valorRecibido;
        public clip(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "galeriaan")
            {
                string valor = "GALERIAAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "documentosan")
            {
                string valor = "DOCUMENTOSAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //camara
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //audio
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "ubicacionan")
            {
                string valor = "UBICACIONAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "contactoan")
            {
                string valor = "CONTACTOAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "encuestaan")
            {
                string valor = "ENCUESTAAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
