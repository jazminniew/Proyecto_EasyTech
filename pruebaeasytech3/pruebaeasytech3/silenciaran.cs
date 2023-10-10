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
    public partial class silenciaran : Form
    {
        string valorRecibido;
        public silenciaran(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "SILENCIARAN")
            {
                string valor = "SILENCIARRAN";
                formcorrecto ventana = new formcorrecto("SILENCIARRAN");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("videollamadaan");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
