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
    public partial class documentosan : Form
    {
        string valorRecibido;
        public documentosan(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "DOCUMENTOSAN")
            {
                string valor = "DOCUMENTOSSAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("DOCUMENTOSSAN");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
