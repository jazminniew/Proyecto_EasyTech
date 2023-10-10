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
    public partial class homewsppandroid : Form
    {
        string valorRecibido;
        string valorRecibido1; 

        public homewsppandroid(string valor, string valor1 = "") 
        {
            InitializeComponent();
            valorRecibido = valor;
            valorRecibido1 = valor1; 
        }
        private void btnaudio_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "audioan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("audioan");
                ventana.Show();
                this.Hide();
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            //volver atras
            formincorrecto ventana = new formincorrecto("");
            ventana.Show();
            this.Hide();
        }

        private void btnemoji_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "stickers")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("stickers");
                ventana.Show();
                this.Hide();
            }
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            //nombre

           if (valorRecibido == "destacadosan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "bloquearan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "vaciaran")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("vaciaran");
                ventana.Show();
                this.Hide();
            }
        }

        private void btnclip_Click(object sender, EventArgs e)
        {
            //clip

            if (valorRecibido == "galeriaan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "documentosan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "ubicacionan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "contactoan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "encuestaan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }

        private void btnvideollamada_Click_1(object sender, EventArgs e)
        {
            if (valorRecibido == "videollamadaan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }

            else
            {
                formincorrecto ventana = new formincorrecto("videollamadaan");
                ventana.Show();
                this.Hide();
            }
        }

        private void btnllamada_Click_1(object sender, EventArgs e)
        {
            if (valorRecibido == "llamadaan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                MessageBox.Show("choco");
                ventana.Show();
                this.Hide();
                return;
            }

            else if (valorRecibido == "llamadaan1") 
            {
                formcorrecto ventana = new formcorrecto(valorRecibido, valorRecibido1);
                MessageBox.Show("lala");
                ventana.Show();
                this.Hide();
                return;
            }

            else
            {
                MessageBox.Show("tete");
                formincorrecto ventana = new formincorrecto("llamadaan");
                ventana.Show();
                this.Hide();
            }
        }

        private void btncamara_Click_1(object sender, EventArgs e)
        {
            if (valorRecibido == "camaraan")
            {

                formcorrecto ventana = new formcorrecto("camaraan");
                ventana.Show();
                this.Hide();
            }
            else
            {
                formincorrecto ventana = new formincorrecto("camaraan");
                ventana.Show();
                this.Hide();
            }
        }

        private void btnpuntos_Click(object sender, EventArgs e)
            {

        }
        // como hago para poner el "mas" que me falta?
            
        private void btnpuntos_Click_1(object sender, EventArgs e)
        {
            if (valorRecibido == "buscaran" )
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "docsan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
           
            else if (valorRecibido == "enclancesan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "silenciaran")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
            else if (valorRecibido == "archivosan")
            {
                formcorrecto ventana = new formcorrecto(valorRecibido);
                ventana.Show();
                this.Hide();
            }
           
            else
            {
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }
    }
    }


