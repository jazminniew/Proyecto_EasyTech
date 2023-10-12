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
    public partial class guardarfoto : Form
    {
        string valorRecibido;
        public guardarfoto(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "GUUARDARFOTO")
            {
                string valor = "GUUUARDARFOTO";
                formcorrecto ventana = new formcorrecto("GUUUARDARFOTO");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("GUUUARDARFOTO");
                ventana.Show();
                this.Hide();
            }
        }

        private void guardarfoto_Load(object sender, EventArgs e)
        {

        }
    }
}
