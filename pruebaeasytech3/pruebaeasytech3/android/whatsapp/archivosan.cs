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
    public partial class archivosan : Form
    {
        string valorRecibido;
        public archivosan(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void btnenclances_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "ENCLANCESAN")
            {
                string valor = "ENCLANCESSAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
           
            else
            {
                formincorrecto ventana = new formincorrecto("ENCLANCESSAN");
                ventana.Show();
                this.Hide();
            }
        }

        private void docs_Click(object sender, EventArgs e)
        {
             if (valorRecibido == "DOCSAN")
            {
                string valor = "DOCSSAN";
                formcorrecto ventana = new formcorrecto(valor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("DOCSAN");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
