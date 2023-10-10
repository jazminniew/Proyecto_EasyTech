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
    public partial class IND_whatsappiphone : Form
    {
        string valor;

        public IND_whatsappiphone()
         
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvideollamada_Click(object sender, EventArgs e)
        {
            string valor = "videollamada";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
             this.Hide();
        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
             string valor = "llamada";
             homewspp ventana = new homewspp(valor);
             ventana.Show();
             this.Hide();
        }

        private void btncamara_Click(object sender, EventArgs e)
        {
             string valor = "camara"; 
             homewspp ventana = new homewspp(valor);
             ventana.Show();
             this.Hide();
        }

        private void btnfotosvideos_Click(object sender, EventArgs e)
        {
            string valor = "fotosvideos";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();            
        }

        private void btndocumentos_Click(object sender, EventArgs e)
        {
            string valor = "documentos"; 
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();            
        }

        private void btnubicacion_Click(object sender, EventArgs e)
        {
            string valor = "ubicacion";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();            
        }

        private void btncontacto_Click(object sender, EventArgs e)
        {
             string valor = "contacto"; 
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();            
        }

        private void btnencuesta_Click(object sender, EventArgs e)
        {
             string valor = "encuesta"; 
            homewspp ventana = new homewspp(valor);
             ventana.Show();
             this.Hide();            
        }

        private void btnsticker_Click(object sender, EventArgs e)
        {
              string valor = "sticker";
              homewspp ventana = new homewspp(valor);
              ventana.Show();
              this.Hide();
        }

        private void btnaudio_Click(object sender, EventArgs e)
        {
             string valor = "audio";
             homewspp ventana = new homewspp(valor);
             ventana.Show();
              this.Hide();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string valor = "buscar";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();
           
        }

        private void btnarchivos_Click(object sender, EventArgs e)
        {
            
             string valor = "archivos"; 
             homewspp ventana = new homewspp("archivos");
             ventana.Show();
             this.Hide();            
        }

        private void btnenclances_Click(object sender, EventArgs e)
        {            
             string valor = "enclances"; 
             homewspp ventana = new homewspp("enclances");
             ventana.Show();
             this.Hide();            
        }

        private void btndocs_Click(object sender, EventArgs e)
        {
             string valor = "docs"; 
             homewspp ventana = new homewspp("docs");
             ventana.Show();
             this.Hide();            
        }

        private void btndestacados_Click(object sender, EventArgs e)
        {
            string valor = "destacados";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();            
        }

        private void btnsilenciar_Click(object sender, EventArgs e)
        {
             string valor = "silenciar";
             homewspp ventana = new homewspp(valor);
             ventana.Show();
             this.Hide();            
        }

        private void btnfondopantalla_Click(object sender, EventArgs e)
        {         
            string valor = "fondopantalla";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();
        }

        private void btnguardarfoto_Click(object sender, EventArgs e)
        {
            string valor = "guardarfoto";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();            
        }


        private void btnbloquear_Click(object sender, EventArgs e)
        {
            
            string valor = "bloquear";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();
           
        }

        private void btnvaciar_Click(object sender, EventArgs e)
        {
            string valor = "vaciar";
            homewspp ventana = new homewspp(valor);
            ventana.Show();
            this.Hide();
            
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            elegirappiphone ventana = new elegirappiphone("");
            ventana.Show();
            this.Hide();
        }

        private void IND_whatsappiphone_Load(object sender, EventArgs e)
        {
        }        }
    }