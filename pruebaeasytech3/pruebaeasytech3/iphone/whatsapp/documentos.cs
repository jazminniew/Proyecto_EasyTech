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
    
    public partial class documentos : Form
    {
        string valorRecibido;
        public documentos(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void btndocumentos_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "Documentos")
            {
                string valor = "DOCUMENTOS";
                formcorrecto ventana = new formcorrecto("DOCUMENTOS");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("DOCUMENTOS");
                ventana.Show();
                this.Hide();
            }
        }

        private void documentos_Load(object sender, EventArgs e)
        {

        }
    }
}
