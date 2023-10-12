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
    public partial class contactoan : Form
    {
        string valorRecibido;
        public contactoan(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "CONTACTOAN")
            {
                string valor = "CONTACTOOAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("CONTACTOOAN");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
