﻿using System;
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
    public partial class maswsppiphone : Form
    {
        string valorRecibido;
        public maswsppiphone(string valor)
        {
            InitializeComponent();
            valorRecibido = valor;
            
        }
        private void btnencuesta_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "encuesta")
            {
                string valor = "ENCUESTA";
                formcorrecto ventana = new formcorrecto(valor);
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
        private void btncontacto_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "contacto")
            {
                string valor = "CONTACTO";
                formcorrecto ventana = new formcorrecto(valor);
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
        private void btnubicacion_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "ubicacion")
            {
                string valor = "Ubicacion";
                formcorrecto ventana = new formcorrecto(valor);
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
        private void btndocumento_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "documentos")
            {
                string valor = "Documentos";
                formcorrecto ventana = new formcorrecto(valor);
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

        private void btnfotosvideos_Click(object sender, EventArgs e)
        {
            if (valorRecibido == "fotosvideos")
            {
                string valor = "fotosyvideos";
                formcorrecto ventana = new formcorrecto(valor);
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
                formincorrecto ventana = new formincorrecto("");
                ventana.Show();
                this.Hide();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            formincorrecto ventana = new formincorrecto("");
            ventana.Show();
            this.Hide();
        }

        private void maswsppiphone_Load(object sender, EventArgs e)
        {

        }
    }
}
