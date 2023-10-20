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
    public partial class multiplechoice : Form
    {

        //variables
        string valorchoice;
        int correctAnswer;   
        
        
        public multiplechoice(string valorindice)
        {
            InitializeComponent();
            
            valorchoice = valorindice; 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {

                lolograste ventana = new lolograste();
                ventana.Show();
                this.Hide();
            }

            else
            {
                correccion ventana = new correccion();
                ventana.Show();
                this.Hide();
            }

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "llamada";
                    button2.Text = "videollamada";
                    button3.Text = "sticker";

                    correctAnswer = 1;
                    break;

                case 2:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "llamada";
                    button2.Text = "videollamada";
                    button3.Text = "sticker";

                    correctAnswer = 2;
                    break;

                case 3:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "audio";
                    button2.Text = "camara";
                    button3.Text = "sticker";

                    correctAnswer = 2;
                    break;

                case 4:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "videollamada";
                    button2.Text = "fotos y videos";
                    button3.Text = "camara";

                    correctAnswer = 2;
                    break;

                case 5:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "ubicacion";
                    button2.Text = "galeria";
                    button3.Text = "documentos";

                    correctAnswer = 3;
                    break;

                case 6:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "ubicacion";
                    button2.Text = "audio";
                    button3.Text = "encuesta";

                    correctAnswer = 1;
                    break;

                case 7:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "fotos y videos";
                    button2.Text = "contacto";
                    button3.Text = "llamada";

                    correctAnswer = 2;
                    break;

                case 8:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "ubicacion";
                    button2.Text = "enviar contacto";
                    button3.Text = "encuesta";

                    correctAnswer = 3;
                    break;

               case 9:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "ubicacion";
                    button2.Text = "audio";
                    button3.Text = "encuesta";

                    correctAnswer = 2;
                    break;

              case 10:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "audio";
                    button2.Text = "stickers";
                    button3.Text = "encuesta";

                    correctAnswer = 1;
                    break;

                case 11:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "buscar";
                    button2.Text = "mensajes destacados";
                    button3.Text = "llamada";

                    correctAnswer = 1;
                    break;

                case 12:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "ubicacion";
                    button2.Text = "archivos";
                    button3.Text = "mensajes destacados";

                    correctAnswer = 1;
                    break;

                case 13:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "mensajes destacados";
                    button2.Text = "audio";
                    button3.Text = "enclances";

                    correctAnswer = 3;
                    break;

                case 14:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "camara";
                    button2.Text = "documentos";
                    button3.Text = "encuesta";

                    correctAnswer = 1;
                    break;

                case 15:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "camara";
                    button2.Text = "mensajes destacados";
                    button3.Text = "silenciar";

                    correctAnswer = 1;
                    break;

                case 16:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "silenciar";
                    button2.Text = "fondo de pantalla";
                    button3.Text = "encuesta";

                    correctAnswer = 2;
                    break;

                case 17:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "guardar en fotos";
                    button2.Text = "documentos";
                    button3.Text = "silenciar";

                    correctAnswer = 1;
                    break;

                case 19:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "bloqurar";
                    button2.Text = "documentos";
                    button3.Text = "vaciar chat";

                    correctAnswer = 1;
                    break;


                case 21:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "silenciar";
                    button2.Text = "vaciar chat";
                    button3.Text = "bloquear";

                    correctAnswer = 3;
                    break;

                case 20:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "vaciar chat";
                    button2.Text = "llamada";
                    button3.Text = "bloquear";

                    correctAnswer = 1;
                    break;

                case 22:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "vaciar chat";
                    button2.Text = "camara";
                    button3.Text = "llamada";

                    correctAnswer = 2;
                    break;

                case 23:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "videollamada";
                    button2.Text = "camara";
                    button3.Text = "fotos y videos";

                    correctAnswer = 2;
                    break;

                case 24:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "enclances";
                    button2.Text = "camara";
                    button3.Text = "audio";

                    correctAnswer = 1;
                    break;

                case 25:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "videollamada";
                    button2.Text = "documentos";
                    button3.Text = "enclances";

                    correctAnswer = 2;
                    break;

                case 26:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "enclances";
                    button2.Text = "mensajes destacados";
                    button3.Text = "stickers";

                    correctAnswer = 1;
                    break;

                case 27:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "enclances";
                    button2.Text = "mensajes destacados";
                    button3.Text = "stickers";

                    correctAnswer = 1;
                    break;

                case 28:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "contacto";
                    button2.Text = "mensajes destacados";
                    button3.Text = "stickers";

                    correctAnswer = 1;
                    break;

                case 29:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "videollamada";
                    button2.Text = "contacto";
                    button3.Text = "llamada";

                    correctAnswer = 2;
                    break;

                case 30:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "silenciar";
                    button2.Text = "mensajes destacados";
                    button3.Text = "contacto";

                    correctAnswer = 3;
                    break;

                case 31:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "fotos y videos";
                    button2.Text = "archivos";
                    button3.Text = "audios";

                    correctAnswer = 2;
                    break;

                case 32:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "archivos";
                    button2.Text = "mensajes destacados";
                    button3.Text = "camara";

                    correctAnswer = 1;
                    break;

                case 33:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "archivos";
                    button2.Text = "camara";
                    button3.Text = "encuesta";

                    correctAnswer = 3;
                    break;

                case 34:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "archivos";
                    button2.Text = "encuesta";
                    button3.Text = "fotos y videos";

                    correctAnswer = 1;
                    break;

                case 35:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "archivos";
                    button2.Text = "encuesta";
                    button3.Text = "fotos y videos";

                    correctAnswer = 2;
                    break;

                case 36:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "audio";
                    button2.Text = "fotos y videos";
                    button3.Text = "videollamada";
                    correctAnswer = 2;
                    break;


                case 37:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "videollamada";
                    button2.Text = "mensajes destacados";
                    button3.Text = "fotos y videos";

                    correctAnswer = 3;
                    break;

                case 38:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "llamada";
                    button2.Text = "encuesta";
                    button3.Text = "fotos y videos";

                    correctAnswer = 3;
                    break;

                case 39:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "documentos";
                    button2.Text = "ubicacion";
                    button3.Text = "contactos";

                    correctAnswer = 1;
                    break;
                case 40:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "encuesta";
                    button2.Text = "camara";
                    button3.Text = "documentos";

                    correctAnswer = 3;
                    break;
                case 41:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "documentos";
                    button2.Text = "contactos";
                    button3.Text = "fotos y videos";

                    correctAnswer = 1;
                    break;

                case 42:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "ubicacion";
                    button2.Text = "contactos";
                    button3.Text = "documentos";

                    correctAnswer = 1;
                    break;

                case 43:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "fotos y videos";
                    button2.Text = "contactos";
                    button3.Text = "ubicacion";

                    correctAnswer = 3;
                    break;

                case 44:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "videollamada";
                    button2.Text = "buscar";
                    button3.Text = "llamada";

                    correctAnswer = 2;
                    break;

                case 45:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "mensajes destacados";
                    button2.Text = "guardar en fotos";
                    button3.Text = "buscar";

                    correctAnswer = 3;
                    break;

                case 46:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "mensajes destacados";
                    button2.Text = "silenciar";
                    button3.Text = "guardar en fotos";

                    correctAnswer = 1;
                    break;

                case 47:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "guardar en fotos";
                    button2.Text = "mensajes destacados";
                    button3.Text = "mensajes temporales";

                    correctAnswer = 3;
                    break;
                case 48:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "silenciar";
                    button2.Text = "mensajes destacados";
                    button3.Text = "mensajes temporales";

                    correctAnswer = 1;
                    break;
                case 49:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "fondo de pantalla";
                    button2.Text = "mensajes destacados";
                    button3.Text = "silenciar";

                    correctAnswer = 3;
                    break;

                case 50:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "fondo de pantalla";
                    button2.Text = "silenciar";
                    button3.Text = "guardar en fotos";

                    correctAnswer = 2;
                    break;
                case 51:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "silenciar";
                    button2.Text = "llamada";
                    button3.Text = "videollamada";

                    correctAnswer = 1;
                    break;
                case 52:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "guardar en fotos";
                    button2.Text = "archivos, enclaancs, docs";
                    button3.Text = "videollamada";

                    correctAnswer = 1;
                    break;
                case 53:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "silenciar";
                    button2.Text = "guardar en fotos";
                    button3.Text = "llamada";

                    correctAnswer = 2;
                    break;
                case 54:

                    lblQuestion.Text = "Cual es la respuesta correcta?";
                    button1.Text = "guardar en fotos";
                    button2.Text = "llamada";
                    button3.Text = "mensajes destacados";

                    correctAnswer = 1;
                    break;

            }

        }
        private void multiplechoice_Load(object sender, EventArgs e)
        {

            //IPHONE

            if (valorchoice == "llamada")
            {
                askQuestion(1);
            }
            if (valorchoice == "videollamada")
            {
                askQuestion(2);
            }

            //camara
            if (valorchoice == "camara")
            {
                askQuestion(3);
            }
            if (valorchoice == "CAMARA")
            {
                askQuestion(22);
            }
            if (valorchoice == "CAMARAA")
            {
                askQuestion(23);
            }

            //fotos y videos
            if (valorchoice == "fotosvideos")
            {
                askQuestion(35);
            }
            if (valorchoice == "fotosyvideos")
            {
                askQuestion(36);
            }
            if (valorchoice == "FOTOSYVIDEOS")
            {
                askQuestion(37);
            }
            if (valorchoice == "FOTOSVIDEOS")
            {
                askQuestion(38);
            }

            //documentos
            if (valorchoice == "documentos")
            {
                askQuestion(39);
            }
            if (valorchoice == "DOCUMENTOS")
            {
                askQuestion(40);
            }
            if (valorchoice == "DOCUMENTOS1")
            {
                askQuestion(41);
            }

            //ubicacion
            if (valorchoice == "ubicacion")
            {
                askQuestion(6);
            }
            if (valorchoice == "Ubicacion")
            {
                askQuestion(42);
            }
            if (valorchoice == "UBICACION")
            {
                askQuestion(43);
            }

            //contacto
            if (valorchoice == "contacto")
            {
                askQuestion(7);
            }
            if (valorchoice == "CONTACTO")
            {
                askQuestion(27);
            }
            if (valorchoice == "CONTACTOO")
            {
                askQuestion(28);
            }
            if (valorchoice == "CONTACTOOO")
            {
                askQuestion(29);
            }
            if (valorchoice == "CONTACTOOOO")
            {
                askQuestion(30);
            }

            //encuesta
            if (valorchoice == "encuesta")
            {
                askQuestion(8);
            }
            if (valorchoice == "ENCUESTA")
            {
                askQuestion(33);
            }
            if (valorchoice == "ENCUESTAA")
            {
                askQuestion(34);
            }

            if (valorchoice == "sticker")
            {
                askQuestion(9);
            }
            if (valorchoice == "audio")
            {
                askQuestion(10);
            }

            //buscar
            if (valorchoice == "buscar")
            {
                askQuestion(11);
            }
            if (valorchoice == "BUSCAR")
            {
                askQuestion(44);
            }
            if (valorchoice == "BUUSCAR")
            {
                askQuestion(45);
            }

            //archivos
            if (valorchoice == "archivos")
            {
                askQuestion(12);
            }
            if (valorchoice == "ARCHIVOS")
            {
                askQuestion(31);
            }
            if (valorchoice == "ARCHIVOS1")
            {
                askQuestion(32);
            }

            //enclances
            if (valorchoice == "enclances")
            {
                askQuestion(13);
            }

            if (valorchoice == "ENCLANCES")
            {
                askQuestion(24);
            }

            if (valorchoice == "ENCLANCES1")
            {
                askQuestion(25);
            }

            if (valorchoice == "ENCLANCES2")
            {
                askQuestion(26);
            }

            if (valorchoice == "docs")
            {
                askQuestion(14);
            }

            //destacados
            if (valorchoice == "destacados")
            {
                askQuestion(15);
            }
            if (valorchoice == "DESTACADOS")
            {
                askQuestion(46);
            }
            if (valorchoice == "DEESTACADOS")
            {
                askQuestion(47);
             }

            //silenciar
            if (valorchoice == "silenciar")
            {
                askQuestion(51);
            }
            if (valorchoice == "SILENCIAR")
            {
                askQuestion(48);
            }
            if (valorchoice == "SIILENCIAR")
            {
                askQuestion(49);
            }
            if (valorchoice == "SIIILENCIAR")
            {
                askQuestion(50);
            }
            //

            if (valorchoice == "fondopantalla")
            {
                askQuestion(17);
            }

            //guardar fotos
            if (valorchoice == "guardarfoto")
            {
                askQuestion(21);
            }
            if (valorchoice == "GUARDARFOTO")
            {
                askQuestion(52);
            }
            if (valorchoice == "GUUARDARFOTO")
            {
                askQuestion(53);
            }
            if (valorchoice == "GUUUARDARFOTO")
            {
                askQuestion(54);
            }
            if (valorchoice == "bloquear")
            {
                askQuestion(19);
            }
            if (valorchoice == "vaciar")
            {
                askQuestion(20);
            }

            //ANDROID

        }

      

      
    }
}