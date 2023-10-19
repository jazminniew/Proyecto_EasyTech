using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_TIC_3RO
{
    public partial class tocafondo : Form
    {
        string valorRecibido;
        public tocafondo(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "FONDOPANTALLA3")
            {
                string valor = "FONDOPANTALLA4";
                formcorrecto ventana = new formcorrecto("FONDOPANTALLA4");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("FONDOPANTALLA4");
                ventana.Show();
                this.Hide();
            }

        }
    }
}
