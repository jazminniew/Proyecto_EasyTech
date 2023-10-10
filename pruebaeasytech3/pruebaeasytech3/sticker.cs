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
   
    public partial class sticker : Form
    {
        string valorRecibido;
        public sticker(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }       

        private void btnstickers_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "stickers")
            {
                string valor = "STICKERS";
                formcorrecto ventana = new formcorrecto("STICKERS");
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
    }
}
