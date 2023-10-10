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
    public partial class elegirappandroid : Form
    {
        private string valorRecibido;
        private string correct;
        public elegirappandroid(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            IND_instagram ventana = new IND_instagram();
            ventana.Show();
            this.Hide();
            
        }

        private void elegirapp_Load(object sender, EventArgs e)
        {
        }

        private void btnsiguiente1_Click(object sender, EventArgs e)
        {
            
                IN_whatsappandroid ventana = new IN_whatsappandroid();
                ventana.Show();
                this.Hide();

          
        }

        private void btnsiguiente2_Click(object sender, EventArgs e)
        {
               IN_configuracionandroid ventana = new IN_configuracionandroid();
                ventana.Show();
                this.Hide();

           
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            seleccionar ventana = new seleccionar();
            ventana.Show();
            this.Hide();
        }
    }
}
