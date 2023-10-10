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
    public partial class silenciar : Form
    {
        string valorRecibido;
        public silenciar(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "SIILENCIAR")
            {
                string valor = "SIIILENCIAR";
                formcorrecto ventana = new formcorrecto("SIIILENCIAR");
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

        private void silenciar_Load(object sender, EventArgs e)
        {

        }
    }
}
