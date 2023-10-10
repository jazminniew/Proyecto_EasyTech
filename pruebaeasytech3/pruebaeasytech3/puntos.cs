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
    public partial class puntos : Form
    {
        string valorRecibido;
        public puntos(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "buscaran")
            {
                string valor = "BUSCARAN";
                formcorrecto ventana = new formcorrecto(valor);
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

        private void btnarchivos_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "archivosan")
            {
                string valor = "ARCHIVOSAN1";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }

            else if (valorRecibido == "enclancesan")
            {
                string valor = "ENCLANCESAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "docsan")
            {
                string valor = "DOCSAN";
                formcorrecto ventana = new formcorrecto(valor);
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

        private void btndocs_Click(object sender, EventArgs e)
        {
        }
         

        private void btnsilenciar_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "silenciaran")
            {
                string valor = "SILENCIARAN";
                formcorrecto ventana = new formcorrecto(valor);
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

        private void btngaleria_Click(object sender, EventArgs e)
        {
           

        }

        private void btnenclances_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            ///mas, tengo que agregar un if como el de puntos para llevar a vaciarchat y bloquear
        }
    }
}
