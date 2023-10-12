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
    public partial class camaraenviar : Form
    {
        string valorRecibido;
        public camaraenviar(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            if (valorRecibido == "FOTOSYVIDEOS")
            {
                string valor = "FOTOSVIDEOS";
                formcorrecto ventana = new formcorrecto("FOTOSVIDEOS");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "CAMARA")
            {
                string valor = "CAMARAA";
                formcorrecto ventana = new formcorrecto("CAMARAA");
                ventana.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("CAMARAA");
                ventana.Show();
                this.Hide();
            }


              }

        private void camaraenviar_Load(object sender, EventArgs e)
        {

        }
    }
}
