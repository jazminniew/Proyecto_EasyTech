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
    public partial class persona : Form
    {
        string valorRecibido;
        public persona(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void persona_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "BUSCAR")
            {
                string valor = "BUUSCAR";
                formcorrecto ventana = new formcorrecto("BUUSCAR");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("BUUSCAR");
                ventana.Show();
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (valorRecibido == "DESTACADOS")
            {
                string valor = "DEESTACADOS";
                formcorrecto ventana = new formcorrecto("DEESTACADOS");
                ventana.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("DEESTACADOS");
                ventana.Show();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "SILENCIAR")
            {
                string valor = "SIILENCIAR";
                formcorrecto ventana = new formcorrecto("SIILENCIAR");
                ventana.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("SIILENCIAR");
                ventana.Show();
                this.Hide();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "GUARDARFOTO")
            {
                string valor = "GUUARDARFOTO";
                formcorrecto ventana = new formcorrecto("GUUARDARFOTO");
                ventana.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("GUUARDARFOTTO");
                ventana.Show();
                this.Hide();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "BLOQUEAR")
            {
                string valor = "BLOQUEAR1";
                formcorrecto ventana = new formcorrecto("BLOQUEAR1");
                ventana.Show();
                this.Hide();
            }
           
            else if (valorRecibido == "VACIAR")
            {
                string valor = "VACIAR1";
                formcorrecto ventana = new formcorrecto("VACIAR1");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("VACIAR1");
                ventana.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "PERSONA")
            {
                string valor = "PERSONA1";
                formcorrecto ventana = new formcorrecto("PERSONA1");
                ventana.Show();
                this.Hide();
            }            

            else if (valorRecibido == "ENCLANCES")
            {
                string valor = "ENCLANCES1";
                formcorrecto ventana = new formcorrecto("ENCLANCES1");
                ventana.Show();
                this.Hide();
            }
           
            else if (valorRecibido == "ARCHIVOS")
            {
                string valor = "ARCHIVOS1";
                formcorrecto ventana = new formcorrecto("ARCHIVOS1");
                ventana.Show();
                this.Hide();
            }

            else if (valorRecibido == "DOCS")
            {
                string valor = "DOCS1";
                formcorrecto ventana = new formcorrecto("DOCS1");
                ventana.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("DOCS1");
                ventana.Show();
                this.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "FONDOPANTALLA")
            {
                string valor = "FONDOPANTALLA1";
                formcorrecto ventana = new formcorrecto("FONDOPANTALLA1");
                ventana.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("FONDOPANTALLA1");
                ventana.Show();
                this.Hide();
            }
        }
    }
    }

