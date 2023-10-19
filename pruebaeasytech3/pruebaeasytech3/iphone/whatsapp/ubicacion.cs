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
    public partial class ubicacion : Form
    {
        string valorRecibido;
        public ubicacion(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string valor = "UBICACION";
            if (valorRecibido == "Ubicacion")
            {
                formcorrecto ventana = new formcorrecto("UBICACION");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("UBICACION");
                ventana.Show();
                this.Hide();
            }
        }

        private void ubicacion_Load(object sender, EventArgs e)
        {

        }
    }
}


