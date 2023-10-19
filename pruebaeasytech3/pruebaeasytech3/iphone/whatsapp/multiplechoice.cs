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

            }
        }
        private void multiplechoice_Load(object sender, EventArgs e)
        {
            if (valorchoice == "llamada")
            {
                askQuestion(1);
            }
            if (valorchoice == "videollamada")
            {
                askQuestion(2);
            }

            if (valorchoice == "camara")
            {
                askQuestion(3);
            }
            
        }

      

      
    }
}
