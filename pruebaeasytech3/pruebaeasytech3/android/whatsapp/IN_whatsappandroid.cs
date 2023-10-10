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
    public partial class IN_whatsappandroid : Form
    {
        public IN_whatsappandroid()
        {
            InitializeComponent();
        }
        private void btnatras_Click(object sender, EventArgs e)
        {
            elegirappandroid ventana = new elegirappandroid();
            ventana.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string valor = "videollamadaan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btnllamada_Click(object sender, EventArgs e)
        {
            string valor = "llamadaan";            
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();

            string valor1 = "llamadaan1"; //anda mal llamada por esto
            homewsppandroid ventana1 = new homewsppandroid(valor1);
            ventana1.Show();
            this.Hide();
        }
        private void btncamara_Click(object sender, EventArgs e)
        {
            string valor = "camaraan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btnsticker_Click(object sender, EventArgs e)
        {
            string valor = "stickers";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            string valor = "audioan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btnfotosvideos_Click(object sender, EventArgs e)
        {
            string valor = "galeriaan"; 
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btndocumentos_Click(object sender, EventArgs e)
        {
            string valor = "documentosan"; 
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btnubicacion_Click(object sender, EventArgs e)
        {
            string valor = "ubicacionan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }

        private void btncontacto_Click(object sender, EventArgs e)
        {
            string valor = "contactoan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }

        private void btnenncuesta_Click(object sender, EventArgs e)
        {
            string valor = "encuestaan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string valor = "buscaran"; 
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btnarchivos_Click(object sender, EventArgs e)
        {
            string valor = "archivosan"; 
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btnenclances_Click(object sender, EventArgs e)
        {
            string valor = "enclancesan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        private void btndocs_Click(object sender, EventArgs e)
        {
            string valor = "docsan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }

        private void btndestacados_Click(object sender, EventArgs e)
        {
            string valor = "destacadosan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }

        private void btnsilenciar_Click(object sender, EventArgs e)
        {
            string valor = "silenciaran";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }

        private void btnfondopantalla_Click(object sender, EventArgs e)
        {
           
        }

        private void btnguardarfoto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbloquear_Click(object sender, EventArgs e)
        {
            string valor = "bloquearan";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }

        private void btnvaciarchat_Click(object sender, EventArgs e)
        {
            string valor = "vaciaran";
            homewsppandroid ventana = new homewsppandroid(valor);
            ventana.Show();
            this.Hide();
        }
        
    }
}

