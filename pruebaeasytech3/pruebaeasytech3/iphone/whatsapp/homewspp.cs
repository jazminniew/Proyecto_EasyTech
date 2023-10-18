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
        private string valorRecibido;
            
        public homewspp(string valorindice)
        {
            InitializeComponent();
            valorRecibido = valorindice;
        }

        //TEXT

         private void homewspp_Load(object sender, EventArgs e)
         {

             if (valorRecibido == "videollamada")
             {
                 lbl1.Text = "Que boton hace que puedas hacer una videollamada?";

             }
             if (valorRecibido == "llamada")
             {
                 lbl1.Text = "Que boton hace que puedas hacer una llamada?";
             }
             if (valorRecibido == "camara")
             {
                 lbl1.Text = "Que boton hace que puedas entrar a la camara?";
             }
             if (valorRecibido == "fotosvideos")
             {
                 lbl1.Text = "Que boton hace que puedas ver tus fotos y videos?";
             }
             if (valorRecibido == "documentos")
             {
                 lbl1.Text = "Que boton sirve para ver tus documentos?";
             }
             if (valorRecibido == "ubicacion")
             {
                 lbl1.Text = "Que boton cumple la funcion de enviar una ubicacion?";
             }
             if (valorRecibido == "contacto")
             {
                 lbl1.Text = "Que boton sirve para enviar un contacto?";
             }
             if (valorRecibido == "encuesta")
             {
                 lbl1.Text = "Que boton sirve para enviar una encuesta?";
             }
             if (valorRecibido == "sticker")
             {
                 lbl1.Text = "Que boton sirve para enviar un sticker?";
             }
             if (valorRecibido == "audio")
             {
                 lbl1.Text = "Que boton sirve para enviar un audio?";
             }
             if (valorRecibido == "buscar")
             {
                 lbl1.Text = "Que boton buscar un mensaje?";
             }

             if (valorRecibido == "archivos")
             {
                 lbl1.Text = "Que boton sirve para enviar un archivo?";
             }

             if (valorRecibido == "enclances")
             {
                 lbl1.Text = "Que boton tocarias para ver los enclances enviados?";
             }
             if (valorRecibido == "docs")
             {
                 lbl1.Text = "Que boton tocarias para ver los documentos enviados?";
             }
             if (valorRecibido == "destacados")
             {
                 lbl1.Text = "Que boton tocarias para ver los mensajes destacados?";
             }
             if (valorRecibido == "silenciar")
             {
                 lbl1.Text = "Que boton tocarias para ver silenciar el chat?";
             }
             if (valorRecibido == "fondopantalla")
             {
                 lbl1.Text = "Que boton tocarias para ver cambiar el fondo de tu pantalla?";
             }
             if (valorRecibido == "guardarfoto")
             {
                 lbl1.Text = "Que boton tocarias cambiar cuando se guardan tus fotos?";
             }
             if (valorRecibido == "bloquear")
             {
                 lbl1.Text = "Que boton tocarias para bloquear el chat?";
             }
             if (valorRecibido == "vaciar")
             {
                   lbl1.Text = "Que boton tocarias para vaciar el chat?";
             }
             

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
                formincorrecto ventana = new formincorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "buscar")
            {
                valorRecibido = "BUSCAR";
                formcorrecto ventana = new formcorrecto("BUSCAR");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "destacados")
            {
                valorRecibido = "DESTACADOS";
                formcorrecto ventana = new formcorrecto("DESTACADOS");
                ventana.Show();
                this.Hide();
            }

            else if (valorRecibido == "silenciar")
            {
                valorRecibido = "SILENCIAR";
                formcorrecto ventana = new formcorrecto("SILENCIAR");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "guardarfoto")
            {
                valorRecibido = "GUARDARFOTO";
                formcorrecto ventana = new formcorrecto("GUARDARFOTO");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "archivos")
            {
                valorRecibido = "ARCHIVOS";
                formcorrecto ventana = new formcorrecto("ARCHIVOS");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "enclances")
            {
                valorRecibido = "ENCLANCES";
                formcorrecto ventana = new formcorrecto("ENCLANCES");
                ventana.Show();
                this.Hide();
            }

            else if (valorRecibido == "vaciar")
            {
                 valorRecibido = "VACIAR";
                formcorrecto ventana = new formcorrecto("VACIAR");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "bloquear")
            {
                valorRecibido = "BLOQUEAR";
                formcorrecto ventana = new formcorrecto("BLOQUEAR");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "fondopantalla")
            {
                valorRecibido = "FONDOPANTALLA";
                formcorrecto ventana = new formcorrecto("FONDOPANTALLA");
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "docs")
            {
                valorRecibido = "DOCS";
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