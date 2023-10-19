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
    public partial class nombre : Form
    {
        string valorRecibido;
        string valorRecibido1;
        public nombre(string valor, string valor1 = "") 
        {
            InitializeComponent();
            valorRecibido = valor;
            valorRecibido1 = valor1;
        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
            if (valorRecibido1 == "llamadaan1") 
            {
                string valor1 = "LLAMADAAN1";
                formcorrecto ventana1 = new formcorrecto(valor1);
                ventana1.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("LLAMADAAN1");
                ventana.Show();
                this.Hide();
            }
        }

        private void btnvideollamada_Click(object sender, EventArgs e)
        {
            //videollamada
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //buscar
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //archivos, encllances, docs
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //silenciar notificaciones
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void nombre_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "destacadosan")
            {
                string valor = "Destacadosan";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
           else if (valorRecibido == "bloquearan")
            {
                string valor = "BLOQUEARAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "vaciaran")
            {
                string valor = "VACIARAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("VACIARAN");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
