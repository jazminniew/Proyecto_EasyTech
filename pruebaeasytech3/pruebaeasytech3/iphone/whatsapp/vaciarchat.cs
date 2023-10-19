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

    public partial class vaciarchat : Form
    {
        string valorRecibido;
        public vaciarchat(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void vaciarchat_Load(object sender, EventArgs e)
        {
           
    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "VACIAR2")
            {
                string valor = "VACIAR3";
                formcorrecto ventana = new formcorrecto("VACIAR3");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("VACIAR3");
                ventana.Show();
                this.Hide();
            }
        }
    }

}


