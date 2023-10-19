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
          
            if (valorRecibido == "videollamada")
            {
                lbl1.Text = "Que boton hace que puedas hacer una videollamada?";
            }
            else if (valorRecibido == "llamada")
            {
                lbl1.Text = "Que boton hace que puedas hacer una llamada?";
            }
            else if (valorRecibido == "camara")
            {
                lbl1.Text = "Que boton hace que puedas entrar a la camara?";
            }
            else if (valorRecibido == "fotosvideos")
            {
                lbl1.Text = "Que boton hace que puedas ver tus fotos y videos?";
            }
            else if (valorRecibido == "documentos")
            {
                lbl1.Text = "Que boton sirve para ver tus documentos?";
            }
            else if (valorRecibido == "ubicacion")
            {
                lbl1.Text = "Que boton cumple la funcion de enviar una ubicacion?";
            }
            else if (valorRecibido == "contacto")
            {
                lbl1.Text = "Que boton sirve para enviar un contacto?";
            }
            else if (valorRecibido == "encuesta")
            {
                lbl1.Text = "Que boton sirve para enviar una encuesta?";
            }
            else if (valorRecibido == "sticker")
            {
                lbl1.Text = "Que boton sirve para enviar un sticker?";
            }
            else if (valorRecibido == "audio")
            {
                lbl1.Text = "Que boton sirve para enviar un audio?";
            }
            else if (valorRecibido == "buscar")
            {
                lbl1.Text = "Que boton buscar un mensaje?";
            }

            else if (valorRecibido == "archivos")
            {
                lbl1.Text = "Que boton sirve para enviar un archivo?";
            }

            else if (valorRecibido == "enclances")
            {
                lbl1.Text = "Que boton tocarias para ver los enclances enviados?";
            }
            else if (valorRecibido == "docs")
            {
                lbl1.Text = "Que boton tocarias para ver los documentos enviados?";
            }
            else if (valorRecibido == "destacados")
            {
                lbl1.Text = "Que boton tocarias para ver los mensajes destacados?";
            }
            else if (valorRecibido == "silenciar")
            {
                lbl1.Text = "Que boton tocarias para ver silenciar el chat?";
            }
            else if (valorRecibido == "fondopantalla")
            {
                lbl1.Text = "Que boton tocarias para ver cambiar el fondo de tu pantalla?";
            }
            else if (valorRecibido == "guardarfoto")
            {
                lbl1.Text = "Que boton tocarias cambiar cuando se guardan tus fotos?";
            }
            else if (valorRecibido == "bloquear")
            {
                lbl1.Text = "Que boton tocarias para bloquear el chat?";
            }
            else if (valorRecibido == "vaciar")
            {
                lbl1.Text = "Que boton tocarias para vaciar el chat?";
            }
            else
            {
                lbl1.Text = "FUNCIONA";
            }
        }

        //TEXT

         private void homewspp_Load(object sender, EventArgs e)
         {
            


         }


        private void btnvideollamada_Click(object sender, EventArgs e)
        {
            
            if (valorRecibido == "videollamada")
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

        private void WS_videollamada_Load(object sender, EventArgs e)
        {

        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "llamada")
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

        private void btncamara_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "camara")
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
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);              

            }
            else if (valorRecibido == "destacados")
            {
                valorRecibido = "DESTACADOS";
                formcorrecto ventana = new formcorrecto("DESTACADOS");
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }

            else if (valorRecibido == "silenciar")
            {
                valorRecibido = "SILENCIAR";
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }
            else if (valorRecibido == "guardarfoto")
            {
                valorRecibido = "GUARDARFOTO";
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }
            else if (valorRecibido == "archivos")
            {
                valorRecibido = "ARCHIVOS";
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }
            else if (valorRecibido == "enclances")
            {
                valorRecibido = "ENCLANCES";
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }

            else if (valorRecibido == "vaciar")
            {
                 valorRecibido = "VACIAR";
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }
            else if (valorRecibido == "bloquear")
            {
                valorRecibido = "BLOQUEAR";
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }
            else if (valorRecibido == "fondopantalla")
            {
                valorRecibido = "FONDOPANTALLA";
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }
            else if (valorRecibido == "docs")
            {
                valorRecibido = "DOCS";
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
                formincorrecto ventanaa = new formincorrecto(valorRecibido);
            }
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
           
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
           
        }
    }
}