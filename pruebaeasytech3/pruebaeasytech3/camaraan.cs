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
    public partial class camaraan : Form

    {
        string valorRecibido;

        public camaraan(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {

            if (valorRecibido == "camaraan")
            {
                string valor = "camaraan1";
                formcorrecto ventana = new formcorrecto("camaraan1");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("camaraan1");
                ventana.Show();
                this.Hide();
            }
        }

    }
}

