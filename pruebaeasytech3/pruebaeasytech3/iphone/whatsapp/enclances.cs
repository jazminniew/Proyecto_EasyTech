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
    public partial class enclances : Form
    {
        string valorRecibido;
        public enclances(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }
        private void docs_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "DOCS1")
            {
                string valor = "DOCS2";
                formcorrecto ventana = new formcorrecto("DOCS2");
                ventana.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("DOCS2");
                ventana.Show();
                this.Hide();
            }
        }
        private void enclances_Load(object sender, EventArgs e)
        {

        }
    }
}
