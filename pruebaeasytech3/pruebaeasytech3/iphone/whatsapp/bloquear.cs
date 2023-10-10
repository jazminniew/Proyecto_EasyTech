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
    public partial class bloquear : Form
    {
        string valorRecibido;
        public bloquear(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "BLOQUEAR15")
            {
                string valor = "BLOQUEAR2";
                formcorrecto ventana = new formcorrecto("BLOQUEAR2");
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

        private void bloquear_Load(object sender, EventArgs e)
        {

        }
    }
}
