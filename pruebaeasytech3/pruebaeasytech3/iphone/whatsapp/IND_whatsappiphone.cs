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
        
        public static string valorindice;

        public IND_whatsappiphone()
         
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvideollamada_Click(object sender, EventArgs e)
        {
            valorindice = "videollamada";   //cambiado de valor a valorindice       
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
             this.Hide();

         
        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
             valorindice = "llamada";
             homewspp ventana = new homewspp(valorindice);
             ventana.Show();
             this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btncamara_Click(object sender, EventArgs e)
        {
             valorindice = "camara"; 
             homewspp ventana = new homewspp(valorindice);
             ventana.Show();
             this.Hide();
             formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnfotosvideos_Click(object sender, EventArgs e)
        {
            valorindice = "fotosvideos";
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btndocumentos_Click(object sender, EventArgs e)
        {
            valorindice = "documentos"; 
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnubicacion_Click(object sender, EventArgs e)
        {
            valorindice = "ubicacion";
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btncontacto_Click(object sender, EventArgs e)
        {
            valorindice = "contacto"; 
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnencuesta_Click(object sender, EventArgs e)
        {
            valorindice = "encuesta"; 
            homewspp ventana = new homewspp(valorindice);
             ventana.Show();
             this.Hide();
            formincorrecto form = new formincorrecto(valorindice);

        }

        private void btnsticker_Click(object sender, EventArgs e)
        {
               valorindice = "sticker";
              homewspp ventana = new homewspp(valorindice);
              ventana.Show();
              this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnaudio_Click(object sender, EventArgs e)
        {
             valorindice = "audio";
             homewspp ventana = new homewspp(valorindice);
             ventana.Show();
              this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            valorindice = "buscar";
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);

        }

        private void btnarchivos_Click(object sender, EventArgs e)
        {
            
             valorindice = "archivos"; 
             homewspp ventana = new homewspp(valorindice);
             ventana.Show();
             this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnenclances_Click(object sender, EventArgs e)
        {            
            valorindice = "enclances"; 
             homewspp ventana = new homewspp(valorindice);
             ventana.Show();
             this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btndocs_Click(object sender, EventArgs e)
        {
             valorindice = "docs"; 
             homewspp ventana = new homewspp(valorindice);
             ventana.Show();
             this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btndestacados_Click(object sender, EventArgs e)
        {
            valorindice = "destacados";
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnsilenciar_Click(object sender, EventArgs e)
        {
              valorindice = "silenciar";
             homewspp ventana = new homewspp(valorindice);
             ventana.Show();
             this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnfondopantalla_Click(object sender, EventArgs e)
        {         
            valorindice = "fondopantalla";
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }

        private void btnguardarfoto_Click(object sender, EventArgs e)
        {
            valorindice = "guardarfoto";
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);
        }


        private void btnbloquear_Click(object sender, EventArgs e)
        {
            
            valorindice = "bloquear";
            homewspp ventana = new homewspp(valorindice);
            ventana.Show();
            this.Hide();
            formincorrecto form = new formincorrecto(valorindice);

        }

        private void btnvaciar_Click(object sender, EventArgs e)
        {
            valorindice = "vaciar";
            homewspp ventana = new homewspp(valorindice);
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