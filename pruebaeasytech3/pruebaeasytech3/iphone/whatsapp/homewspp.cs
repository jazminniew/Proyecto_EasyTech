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
    public partial class homewspp : Form
    {
        string valorRecibido;
            
        public homewspp(string valorindice)
        {
            InitializeComponent();
            valorRecibido = valorindice;
        }
        
        private void btnvideollamada_Click(object sender, EventArgs e)
        {
            
            if (valorRecibido == "videollamada")
            {
                formcorrecto ventana = new formcorrecto("videollamada");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("videollamada");
                ventana.Show();
                this.Hide();
            }

        }

        private void WS_videollamada_Load(object sender, EventArgs e)
        {

        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "llamada")
            {
                formcorrecto ventana = new formcorrecto("llamada");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("llamada");
                ventana.Show();
                this.Hide();
            }
        }

        private void btncamara_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "camara")
            {
                
                formcorrecto ventana = new formcorrecto("camara");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("camara");
                ventana.Show();
                this.Hide();
            }
        }

        private void btnsticker_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "sticker")
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

        private void btnaudio_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "audio")
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

        private void btnatras_Click(object sender, EventArgs e)
        {
            
        }
        private void btnmas_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "camara" || valorRecibido == "fotosvideos" || valorRecibido == "documentos" || valorRecibido == "ubicacion" || valorRecibido == "contacto" || valorRecibido == "encuesta")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto(""); //COMO PASO TANTOS VALORES INCORRECTOS?
                ventana.Show();
                this.Hide();
            }
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "buscar")
            {
                string valor = "BUSCAR";
                formcorrecto ventana = new formcorrecto("BUSCAR");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "destacados")
            {
                string valor = "DESTACADOS";
                formcorrecto ventana = new formcorrecto("DESTACADOS");
                ventana.Show();
                this.Hide();
            }

            else if (valorRecibido == "silenciar")
            {
                string valor = "SILENCIAR";
                formcorrecto ventana = new formcorrecto("SILENCIAR");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "guardarfoto")
            {
                string valor = "GUARDARFOTO";
                formcorrecto ventana = new formcorrecto("GUARDARFOTO");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "archivos")
            {
                string valor = "ARCHIVOS";
                formcorrecto ventana = new formcorrecto("ARCHIVOS");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "enclances")
            {
                string valor = "ENCLANCES";
                formcorrecto ventana = new formcorrecto("ENCLANCES");
                ventana.Show();
                this.Hide();
            }

            else if (valorRecibido == "vaciar")
            {
                string valor = "VACIAR";
                formcorrecto ventana = new formcorrecto("VACIAR");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "bloquear")
            {
                string valor = "BLOQUEAR";
                formcorrecto ventana = new formcorrecto("BLOQUEAR");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "fondopantalla")
            {
                string valor = "FONDOPANTALLA";
                formcorrecto ventana = new formcorrecto("FONDOPANTALLA");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "docs")
            {
                string valor = "DOCS";
                formcorrecto ventana = new formcorrecto("DOCS");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("DOCS");
                ventana.Show();
                this.Hide();
            }
           
        }
    }
}