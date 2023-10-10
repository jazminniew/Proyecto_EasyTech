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
    public partial class fotosvideoss : Form
    {
        string valorRecibido;
        public fotosvideoss(string valor) 
        {
            InitializeComponent();
            valorRecibido = valor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "fotosyvideos")
            {
                string valor = "FOTOSYVIDEOS";
                formcorrecto ventana = new formcorrecto("FOTOSYVIDEOS");
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

        private void fotosvideoss_Load(object sender, EventArgs e)
        {

        }
    }
}
