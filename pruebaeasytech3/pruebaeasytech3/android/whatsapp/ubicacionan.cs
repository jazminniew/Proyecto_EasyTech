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
    public partial class ubicacionan : Form
    {
        string valorRecibido;
        public ubicacionan(string valor)
        {

            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "UBICACIONAN")
            {
                string valor = "UBICACIONNAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("UBICACIONNAN");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
