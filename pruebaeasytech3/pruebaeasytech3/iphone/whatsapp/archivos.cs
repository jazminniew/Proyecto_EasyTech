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
    public partial class archivos : Form
    {
        string valorRecibido;
        public archivos(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }
        private void btnenclances_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "ENCLANCES1")
            {
                string valor = "ENCLANCES2";
                formcorrecto ventana = new formcorrecto("ENCLANCES2");
                ventana.Show();
                this.Hide();
            }

            else if (valorRecibido == "DOCS1")
            {
                string valor = "DOCS2";
                formcorrecto ventana = new formcorrecto("DOCS2");
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
        private void archivos_Load(object sender, EventArgs e)
        {

        }
    }
}
