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
    public partial class enviarfotosan : Form
    {
        string valorRecibido;
        public enviarfotosan(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "GALERIAAAN")
            {
                string valor = "GALERIAAAAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }

            else if (valorRecibido == "DOCUMENTOSSAN")
            {
                string valor = "DOCUMENTOSSSAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("DOCUMENTOSSSAN");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
