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
    public partial class abrirdocumento : Form
    {
        string valorRecibido;
        public abrirdocumento(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "DOCUMENTOS")
            {
                string valor = "DOCUMENTOS1";
                formcorrecto ventana = new formcorrecto("DOCUMENTOS1");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
