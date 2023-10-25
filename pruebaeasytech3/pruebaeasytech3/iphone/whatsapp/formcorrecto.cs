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
    public partial class formcorrecto : Form
    {
        public string valorcorrecto;
        public string valorcorrecto1; 
        public formcorrecto(string valorRecibido, string valorRecibido1 = "") 
        {
            InitializeComponent();
            valorcorrecto = valorRecibido;
            valorcorrecto1 = valorRecibido1; 
        }

        public int Interval { get; private set; }
        private void formcorrecto_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            //IPHONE

            //videollamada
            if (valorcorrecto == "videollamada")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //llamada
            if (valorcorrecto == "llamada")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //camara
            if (valorcorrecto == "camara")
            {
                camara ventana = new camara("camara");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "CAMARA")
            {
                camaraenviar ventana = new camaraenviar("CAMARA");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "CAMARAA")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //enclances
            if (valorcorrecto == "enclances")
            {
                homewspp ventana = new homewspp("enclances");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "ENCLANCES")
            {
                persona ventana = new persona("ENCLANCES");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ENCLANCES1")
            {
                archivos ventana = new archivos("ENCLANCES1");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ENCLANCES2")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }


            //audio
            if (valorcorrecto == "audio")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //sticker
            if (valorcorrecto == "sticker")
            {
                stickers ventana = new stickers();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }


            //documentos
            if (valorcorrecto == "documentos")
            {
                maswsppiphone ventana = new maswsppiphone("documentos");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //ubicacion
            if (valorcorrecto == "ubicacion")
            {
                maswsppiphone ventana = new maswsppiphone("ubicacion");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //contacto
            if (valorcorrecto == "contacto")
            {
                maswsppiphone ventana = new maswsppiphone("contacto");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "CONTACTO")
            {
                compartircontactos ventana = new compartircontactos("CONTACTO");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "CONTACTOO")
            {
                compartircontactosselect ventana = new compartircontactosselect("CONTACTOO");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "CONTACTOOO")
            {
                compartircontactosenviar ventana = new compartircontactosenviar("CONTACTOOO");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "CONTACTOOOO")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //ARCHIVOS
            if (valorcorrecto == "archivos")
            {
                homewspp ventana = new homewspp("archivos");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ARCHIVOS")
            {
                persona ventana = new persona("ARCHIVOS");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ARCHIVOS1")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }


            //encuesta
            if (valorcorrecto == "encuesta")
            {
                maswsppiphone ventana = new maswsppiphone("encuesta");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ENCUESTA")
            {
                encuesta ventana = new encuesta("ENCUESTA");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ENCUESTAA")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //fotosvideos
            if (valorcorrecto == "fotosvideos")
            {
                maswsppiphone ventana = new maswsppiphone("fotosvideos");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "fotosyvideos")
            {
                fotosvideoss ventana = new fotosvideoss("fotosyvideos");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "FOTOSYVIDEOS")
            {
                camaraenviar ventana = new camaraenviar("FOTOSYVIDEOS");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "FOTOSVIDEOS")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //documentos
            if (valorcorrecto == "Documentos")
            {
                documentos ventana = new documentos("Documentos");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "DOCUMENTOS")
            {
                abrirdocumento ventana = new abrirdocumento("DOCUMENTOS");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCUMENTOS1")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //ubicacion
            if (valorcorrecto == "Ubicacion")
            {
                ubicacion ventana = new ubicacion("Ubicacion");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "UBICACION")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //buscar
            if (valorcorrecto == "buscar")
            {
                homewspp ventana = new homewspp("buscar");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BUSCAR")
            {
                persona ventana = new persona("BUSCAR");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BUUSCAR")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //destacados
            if (valorcorrecto == "destacados")
            {
                homewspp ventana = new homewspp("destacados");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DESTACADOS")
            {
                persona ventana = new persona("DESTACADOS");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DEESTACADOS")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //silenciar
            if (valorcorrecto == "silenciar")
            {
                homewspp ventana = new homewspp("silenciar");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "SILENCIAR")
            {
                persona ventana = new persona("SILENCIAR");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "SIILENCIAR")
            {
                silenciar ventana = new silenciar("SIILENCIAR");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "SIIILENCIAR")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //guardarfoto
            if (valorcorrecto == "guardarfoto")
            {
                homewspp ventana = new homewspp("guardarfoto");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "GUARDARFOTO")
            {
                persona ventana = new persona("GUARDARFOTO");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "GUUARDARFOTO")
            {
                guardarfoto ventana = new guardarfoto("GUUARDARFOTO");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "GUUUARDARFOTO")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }


            //bloquear
            if (valorcorrecto == "bloquear")
            {
                homewspp ventana = new homewspp("bloquear");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BLOQUEAR")
            {
                persona ventana = new persona("BLOQUEAR");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BLOQUEAR1")
            {
                abajopersona ventana = new abajopersona("BLOQUEAR1");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BLOQUEAR15")
            {
                bloquear ventana = new bloquear("BLOQUEAR15");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BLOQUEAR2")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //vaciarchat
            if (valorcorrecto == "vaciar")
            {
                homewspp ventana = new homewspp("vaciar");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "VACIAR")
            {
                persona ventana = new persona("VACIAR");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            else if (valorcorrecto == "VACIAR1")
            {
                abajopersona ventana = new abajopersona("VACIAR1");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            else if (valorcorrecto == "VACIAR2")
            {
                vaciarchat ventana = new vaciarchat("VACIAR2");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            else if (valorcorrecto == "VACIAR3")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            // FONDOPANTALLA

            if (valorcorrecto == "fondopantalla")
            {
                homewspp ventana = new homewspp("fondopantalla");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "FONDOPANTALLA")
            {
                persona ventana = new persona("FONDOPANTALLA");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "FONDOPANTALLA1")
            {
                eligefondo ventana = new eligefondo("FONDOPANTALLA1");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "FONDOPANTALLA22")
            {
                eligefondossss ventana = new eligefondossss("FONDOPANTALLA22");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "FONDOPANTALLA3")
            {
                tocafondo ventana = new tocafondo("FONDOPANTALLA3");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "FONDOPANTALLA4")
            {
                fijarfondo ventana = new fijarfondo("FONDOPANTALLA4");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "FONDOPANTALLA5")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            //DOCS
            if (valorcorrecto == "docs")
            {
                homewspp ventana = new homewspp("docs");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCS")
            {
                persona ventana = new persona("DOCS");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCS1")
            {
                enclances ventana = new enclances("DOCS1");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCS2")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //-------------------------ANDROID-------------------------------//

            //videollamada
            if (valorcorrecto == "videollamadaan")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //llamada
            if (valorcorrecto == "llamadaan")
            {

                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "llamadaan1")
            {
                nombre ventana = new nombre("llamadaan1");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }


            //camara
            if (valorcorrecto == "camaraan")
            {
                camaraan ventana = new camaraan("camaraan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "camaraan1")
            {
                camaraenviaran ventana = new camaraenviaran("camaraan1");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "camaraan2")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //audio
            if (valorcorrecto == "audioan")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //------PUNTOSS--------

            //buscar
            if (valorcorrecto == "buscaran")
            {
                puntos ventana = new puntos("buscaran");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BUSCARAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //archivos
            if (valorcorrecto == "archivosan")
            {
                puntos ventana = new puntos("archivosan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "ARCHIVOSAN1")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            //sticker
            if (valorcorrecto == "stickers")
            {
                sticker ventana = new sticker("stickers");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "STICKERS")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //galeria

            //enclances
            if (valorcorrecto == "enclancesan")
            {
                puntos ventana = new puntos("enclancesan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ENCLANCESAN")
            {
                archivosan ventana = new archivosan("ENCLANCESAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ENCLANCESSAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //docs
            if (valorcorrecto == "docsan")
            {
                puntos ventana = new puntos("docsan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCSAN")
            {
                archivosan ventana = new archivosan("DOCSAN");
                Program.lastTryForm = new homewspp(valorcorrecto);

                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCSSAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //silenciar
            if (valorcorrecto == "silenciaran")
            {
                puntos ventana = new puntos("silenciaran");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "SILENCIARAN")
            {
                silenciaran ventana = new silenciaran("SILENCIARAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "SILENCIARRAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //galeria

            if (valorcorrecto == "galeriaan")
            {
                clip ventana = new clip("galeriaan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "GALERIAAN")
            {
                galeriaan ventana = new galeriaan("GALERIAAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "GALERIAAAN")
            {
                enviarfotosan ventana = new enviarfotosan("GALERIAAAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "GALERIAAAAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //documentos

            if (valorcorrecto == "documentosan")
            {
                clip ventana = new clip("documentosan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCUMENTOSAN")
            {
                documentosan ventana = new documentosan("DOCUMENTOSAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCUMENTOSSAN")
            {
                enviarfotosan ventana = new enviarfotosan("DOCUMENTOSSAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DOCUMENTOSSSAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //ubicacion
            if (valorcorrecto == "ubicacionan")
            {
                clip ventana = new clip("ubicacionan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "UBICACIONAN")
            {
                ubicacionan ventana = new ubicacionan("UBICACIONAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            if (valorcorrecto == "UBICACIONNAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //contacto
            if (valorcorrecto == "contactoan")
            {
                clip ventana = new clip("contactoan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "CONTACTOAN")
            {
                contactoan ventana = new contactoan("CONTACTOAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "CONTACTOOAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //encuesta
            if (valorcorrecto == "encuestaan")
            {
                clip ventana = new clip("encuestaan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ENCUESTAAN")
            {
                encuestaan ventana = new encuestaan("ENCUESTAAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "ENCUESTAAAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //destacados
            if (valorcorrecto == "destacadosan")
            {
                nombre ventana = new nombre("destacadosan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "Destacadosan")
            {
                nombreabajo ventana = new nombreabajo("Destacadosan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "DESTACADOSAN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //bloquear
            if (valorcorrecto == "bloquearan")
            {
                nombre ventana = new nombre("bloquearan");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BLOQUEARAN")
            {
                nombreabajo ventana = new nombreabajo("BLOQUEARAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "BLOQUEARANN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //vaciar
            if (valorcorrecto == "vaciaran")
            {
                nombre ventana = new nombre("vaciaran");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "VACIARAN")
            {
                nombreabajo ventana = new nombreabajo("VACIARAN");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }
            if (valorcorrecto == "VACIARANN")
            {
                lolograste ventana = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana.Show();
                this.Hide();
            }

            //LLAMADA NUEVO

            if (valorcorrecto1 == "llamadaan1")
            {
                nombre ventana1 = new nombre("llamadaan1");
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana1.Show();
                this.Hide();
            }
            if (valorcorrecto1 == "LLAMADAAN1")
            {
                lolograste ventana1 = new lolograste();
                Program.lastTryForm = new homewspp(valorcorrecto);
                ventana1.Show();
                this.Hide();
            }

        }





        }
    }

