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
    public partial class seleccionardocumento : Form
    {
        string valorRecibido;
        public seleccionardocumento(string valor)
        {
            InitializeComponent();
            valor = valorRecibido;
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "documentos")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
        }

        private void seleccionardocumento_Load(object sender, EventArgs e)
        {

        }
    }
}
