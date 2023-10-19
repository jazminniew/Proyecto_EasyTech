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
    public partial class eligefondossss : Form
    {
        string valorRecibido;
        public eligefondossss(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void eligefondossss_Load(object sender, EventArgs e)
        {
           
        }

        private void btnfondos_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "FONDOPANTALLA22")
            {
                string valor = "FONDOPANTALLA3";
                formcorrecto ventana = new formcorrecto("FONDOPANTALLA3");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("FONDOPANTALLA3");
                ventana.Show();
                this.Hide();
            }
        }
    }
}
