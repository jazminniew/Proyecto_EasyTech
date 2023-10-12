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
    public partial class abajopersona : Form
    {
        string valorRecibido;
        public abajopersona(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "BLOQUEAR1" || valorRecibido == "VACIAR1")
            {
                formincorrecto ventana = new formincorrecto("BLOQEUAR1"); //falta vaciar1
                ventana.Show();
                this.Hide();
            }            
             else
            {
                formcorrecto ventana = new formcorrecto("");
                ventana.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "BLOQUEAR1")
            {
                string valor = "BLOQUEAR15";
                formcorrecto ventana = new formcorrecto("BLOQUEAR15");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("BLOQEUAR15");
                ventana.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "VACIAR1")
            {
                string valor = "VACIAR2";
                formcorrecto ventana = new formcorrecto("VACIAR2");
                ventana.Show();
                this.Hide();                
            }
            else
            {
                formincorrecto ventana = new formincorrecto("VACIAR2");
                ventana.Show();
                this.Hide();
            }
        }

        private void abajopersona_Load(object sender, EventArgs e)
        {

        }
    }
    }

