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
    public partial class compartircontactos : Form
    {
        string valorRecibido;
        public compartircontactos(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "CONTACTO")
            {
                string valor = "CONTACTOO";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("CONTACTOO");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
