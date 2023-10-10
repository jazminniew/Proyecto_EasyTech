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
    public partial class camaraenviaran : Form
    {
        string valorRecibido;
        public camaraenviaran(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

           if (valorRecibido == "camaraan1")
            {
                string valor = "camaraan2";
                formcorrecto ventana = new formcorrecto("camaraan2");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("camaraan2");
                ventana.Show();
                this.Hide();
            }


        }

        private void camaraenviar_Load(object sender, EventArgs e)
        {

        }
    }
}
