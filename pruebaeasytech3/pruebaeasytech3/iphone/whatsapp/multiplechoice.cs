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


            if (valorchoice == "fotosvideos")
            {
                askQuestion(4);
            }
            if (valorchoice == "documentos")
            {
                askQuestion(5);
            }
            if (valorchoice == "ubicacion")
            {
                askQuestion(6);
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



            if (valorchoice == "encuesta")
            {
                askQuestion(8);
            }
            if (valorchoice == "sticker")
            {
                askQuestion(9);
            }
            if (valorchoice == "audio")
            {
                askQuestion(10);
            }
            if (valorchoice == "buscar")
            {
                askQuestion(11);
            }
            if (valorchoice == "archivos")
            {
                askQuestion(12);
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
            if (valorchoice == "destacados")
            {
                askQuestion(15);
            }
            if (valorchoice == "silenciar")
            {
                askQuestion(16);
            }
            if (valorchoice == "fondopantalla")
            {
                askQuestion(17);
            }
            if (valorchoice == "guardarfotos")
            {
                askQuestion(21);
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