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
    public partial class formincorrecto : Form
    {
        public string valorincorrecto;
        public string valorincoorrectopasos;
        public formincorrecto(string valorindice, string valorRecibido = "")
        {
            InitializeComponent();
            valorincorrecto = valorindice;//CORREGIR ESTOOOO
            //valorincorrectopasos = valorRecibido; COMO HAGO PARA PONER UN VALOR RECIBIDO TIPO VALOR INCORRECTO OTRO VALOR
            
        }
        public int Interval { get; private set; }

        private void formincorrecto_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (valorincorrecto == "videollamada")
           {
                multiplechoice ventana = new multiplechoice("videollamada");
                ventana.Show();
                this.Close();
           }

           else if (valorincorrecto == "llamada")
            {
                multiplechoice ventana = new multiplechoice("llamada");
                ventana.Show();
                this.Close(); 

            }

            else if (valorincorrecto == "camara")
            {
                multiplechoice ventana = new multiplechoice("camara");
                ventana.Show();
                this.Close();

            }
            else if (valorincorrecto == "sticker")
            {
                multiplechoice ventana = new multiplechoice("sticker");
                ventana.Show();
                this.Close();

           }
            else if (valorincorrecto == "audio")
            {
                multiplechoice ventana = new multiplechoice("audio");
                ventana.Show();
                this.Close();

            }
            else if (valorincorrecto == "camara")
            {
                multiplechoice ventana = new multiplechoice("camara");
                ventana.Show();
                this.Close();

            }
            else if (valorincorrecto == "CAMARA")
            {
                multiplechoice ventana = new multiplechoice("CAMARA");
                ventana.Show();
                this.Close();
                }
            else if (valorincorrecto == "CAMARAA")
            {
                multiplechoice ventana = new multiplechoice("CAMARAA");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "fotosvideos")
            {
                multiplechoice ventana = new multiplechoice("fotosvideos");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "fotosyvideos")
            {
                multiplechoice ventana = new multiplechoice("fotosyvideos");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "FOTOSYVIDEOS")
            {
                multiplechoice ventana = new multiplechoice("FOTOSYVIDEOS");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "FOTOSVIDEOS")
            {
                multiplechoice ventana = new multiplechoice("FOTOSVIDEOS");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "documentos")
            {
                multiplechoice ventana = new multiplechoice("documentos");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "DOCUMENTOS")
            {
                multiplechoice ventana = new multiplechoice("DOCUMENTOS");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "DOCUMENTOS1")
            {
                multiplechoice ventana = new multiplechoice("DOCUMENTOS1");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "ubicacion")
            {
                multiplechoice ventana = new multiplechoice("ubicacion");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "Ubicacion")
            {
                multiplechoice ventana = new multiplechoice("Ubicacion");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "UBICACION")
            {
                multiplechoice ventana = new multiplechoice("UBICACION");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "contacto")
            {
                multiplechoice ventana = new multiplechoice("contacto");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "CONTACTO")
            {
                multiplechoice ventana = new multiplechoice("CONTACTO");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "CONTACTOO")
            {
                multiplechoice ventana = new multiplechoice("CONTACTOO");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "CONTACTOOO")
            {
                multiplechoice ventana = new multiplechoice("CONTACTOOO");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "CONTACTOOOO")
            {
                multiplechoice ventana = new multiplechoice("CONTACTOOOO");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "encuesta")
            {
                multiplechoice ventana = new multiplechoice("encuesta");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "ENCUESTA")
            {
                multiplechoice ventana = new multiplechoice("ENCUESTA");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "ENCUESTAA")
            {
                multiplechoice ventana = new multiplechoice("ENCUESTAA");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "sticker")
            {
                multiplechoice ventana = new multiplechoice("sticker");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "audio")
            {
                multiplechoice ventana = new multiplechoice("audio");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "buscar")
            {
                multiplechoice ventana = new multiplechoice("buscar");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "BUSCAR")
            {
                multiplechoice ventana = new multiplechoice("BUSCAR");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "BUUSCAR")
            {
                multiplechoice ventana = new multiplechoice("BUUSCAR");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "archivos")
            {
                multiplechoice ventana = new multiplechoice("archivos");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "ARCHIVOS")
            {
                multiplechoice ventana = new multiplechoice("ARCHIVOS");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "ARCHIVOS1")
            {
                multiplechoice ventana = new multiplechoice("ARCHIVOS1");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "enclances")
            {
                multiplechoice ventana = new multiplechoice("enclances");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "ENCLANCES")
            {
                multiplechoice ventana = new multiplechoice("ENCLANCES");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "ENCLANCES1")
            {
                multiplechoice ventana = new multiplechoice("ENCLANCES1");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "ENCLANCES2")
            {
                multiplechoice ventana = new multiplechoice("ENCLANCES2");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "docs")
            {
                multiplechoice ventana = new multiplechoice("docs");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "DOCS")
            {
                multiplechoice ventana = new multiplechoice("DOCS");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "DOCS1")
            {
                multiplechoice ventana = new multiplechoice("DOCS1");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "DOCS2")
            {
                multiplechoice ventana = new multiplechoice("DOCS2");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "destacados")
            {
                multiplechoice ventana = new multiplechoice("destacados");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "DESTACADOS")
            {
                multiplechoice ventana = new multiplechoice("DESTACADOS");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "DEESTACADOS")
            {
                multiplechoice ventana = new multiplechoice("DEESTACADOS");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "silenciar")
            {
                multiplechoice ventana = new multiplechoice("silenciar");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "SILENCIAR")
            {
                multiplechoice ventana = new multiplechoice("SILENCIAR");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "SIILENCIAR")
            {
                multiplechoice ventana = new multiplechoice("SIILENCIAR");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "SIIILENCIAR")
            {
                multiplechoice ventana = new multiplechoice("SIIILENCIAR");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "fondopantalla")
            {
                multiplechoice ventana = new multiplechoice("fondopantalla");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "FONDOPANTALLA")
            {
                multiplechoice ventana = new multiplechoice("FONDOPANTALLA");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "FONDOPANTALLA1")
            {
                multiplechoice ventana = new multiplechoice("FONDOPANTALLA1");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "FONDOPANTALLA22")
            {
                multiplechoice ventana = new multiplechoice("FONDOPANTALLA22");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "FONDOPANTALLA3")
            {
                multiplechoice ventana = new multiplechoice("FONDOPANTALLA3");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "FONDOPANTALLA4")
            {
                multiplechoice ventana = new multiplechoice("FONDOPANTALLA4");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "FONDOPANTALLA5")
            {
                multiplechoice ventana = new multiplechoice("FONDOPANTALLA5");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "guardarfoto")
            {
                multiplechoice ventana = new multiplechoice("guardarfoto");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "GUARDARFOTO")
            {
                multiplechoice ventana = new multiplechoice("GUARDARFOTO");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "GUUARDARFOTO")
            {
                multiplechoice ventana = new multiplechoice("GUUARDARFOTO");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "GUUUUARDARFOTO")
            {
                multiplechoice ventana = new multiplechoice("GUUUARDARFOTO");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "bloquear")
            {
                multiplechoice ventana = new multiplechoice("bloquear");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "BLOQUEAR")
            {
                multiplechoice ventana = new multiplechoice("BLOQUEAR");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "BLOQUEAR1")
            {
                multiplechoice ventana = new multiplechoice("BLOQUEAR1");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "BLOQUEAR15")
            {
                multiplechoice ventana = new multiplechoice("BLOQUEAR15");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "BLOQUEAR2")
            {
                multiplechoice ventana = new multiplechoice("BLOQUEAR2");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "vaciar")
            {
                multiplechoice ventana = new multiplechoice("vaciar");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "VACIAR")
            {
                multiplechoice ventana = new multiplechoice("VACIAR");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "VACIAR1")
            {
                multiplechoice ventana = new multiplechoice("VACIAR1");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "VACIAR2")
            {
                multiplechoice ventana = new multiplechoice("VACIAR2");
                ventana.Show();
                this.Close();
            }
            else if (valorincorrecto == "VACIAR3")
            {
                multiplechoice ventana = new multiplechoice("VACIAR3");
                ventana.Show();
                this.Close();
            }
            else
            {
                multiplechoice ventana = new multiplechoice(""); //MAL
                ventana.Show();
                this.Close();
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
