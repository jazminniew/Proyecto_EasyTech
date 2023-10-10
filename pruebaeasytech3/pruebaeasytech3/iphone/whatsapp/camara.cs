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
    public partial class camara : Form
       
    {
        string valorRecibido;

        public camara(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {

            if (valorRecibido == "camara")
            {
                string valor = "CAMARA";
                formcorrecto ventana = new formcorrecto("CAMARA");
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

