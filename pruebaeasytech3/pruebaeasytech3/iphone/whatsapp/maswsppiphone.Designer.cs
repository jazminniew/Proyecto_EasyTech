
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class maswsppiphone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnencuesta = new System.Windows.Forms.Button();
            this.btncontacto = new System.Windows.Forms.Button();
            this.btnubicacion = new System.Windows.Forms.Button();
            this.btndocumento = new System.Windows.Forms.Button();
            this.btnfotosvideos = new System.Windows.Forms.Button();
            this.btncamara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Toca el boton que creas que va a cumplir la funcion:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(244, 392);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(374, 46);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnencuesta
            // 
            this.btnencuesta.Location = new System.Drawing.Point(244, 345);
            this.btnencuesta.Name = "btnencuesta";
            this.btnencuesta.Size = new System.Drawing.Size(374, 41);
            this.btnencuesta.TabIndex = 19;
            this.btnencuesta.Text = "encuesta";
            this.btnencuesta.UseVisualStyleBackColor = true;
            this.btnencuesta.Click += new System.EventHandler(this.btnencuesta_Click);
            // 
            // btncontacto
            // 
            this.btncontacto.Location = new System.Drawing.Point(244, 307);
            this.btncontacto.Name = "btncontacto";
            this.btncontacto.Size = new System.Drawing.Size(374, 41);
            this.btncontacto.TabIndex = 20;
            this.btncontacto.Text = "contacto";
            this.btncontacto.UseVisualStyleBackColor = true;
            this.btncontacto.Click += new System.EventHandler(this.btncontacto_Click);
            // 
            // btnubicacion
            // 
            this.btnubicacion.Location = new System.Drawing.Point(244, 269);
            this.btnubicacion.Name = "btnubicacion";
            this.btnubicacion.Size = new System.Drawing.Size(374, 41);
            this.btnubicacion.TabIndex = 21;
            this.btnubicacion.Text = "ubicacion";
            this.btnubicacion.UseVisualStyleBackColor = true;
            this.btnubicacion.Click += new System.EventHandler(this.btnubicacion_Click);
            // 
            // btndocumento
            // 
            this.btndocumento.Location = new System.Drawing.Point(244, 232);
            this.btndocumento.Name = "btndocumento";
            this.btndocumento.Size = new System.Drawing.Size(374, 41);
            this.btndocumento.TabIndex = 22;
            this.btndocumento.Text = "documento";
            this.btndocumento.UseVisualStyleBackColor = true;
            this.btndocumento.Click += new System.EventHandler(this.btndocumento_Click);
            // 
            // btnfotosvideos
            // 
            this.btnfotosvideos.Location = new System.Drawing.Point(244, 195);
            this.btnfotosvideos.Name = "btnfotosvideos";
            this.btnfotosvideos.Size = new System.Drawing.Size(374, 41);
            this.btnfotosvideos.TabIndex = 23;
            this.btnfotosvideos.Text = "fotos y videos";
            this.btnfotosvideos.UseVisualStyleBackColor = true;
            this.btnfotosvideos.Click += new System.EventHandler(this.btnfotosvideos_Click);
            // 
            // btncamara
            // 
            this.btncamara.Location = new System.Drawing.Point(244, 160);
            this.btncamara.Name = "btncamara";
            this.btncamara.Size = new System.Drawing.Size(374, 41);
            this.btncamara.TabIndex = 24;
            this.btncamara.Text = "camara";
            this.btncamara.UseVisualStyleBackColor = true;
            this.btncamara.Click += new System.EventHandler(this.btncamara_Click);
            // 
            // maswsppiphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncamara);
            this.Controls.Add(this.btnfotosvideos);
            this.Controls.Add(this.btndocumento);
            this.Controls.Add(this.btnubicacion);
            this.Controls.Add(this.btncontacto);
            this.Controls.Add(this.btnencuesta);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Name = "maswsppiphone";
            this.Text = "maswsppiphone";
            this.Load += new System.EventHandler(this.maswsppiphone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnencuesta;
        private System.Windows.Forms.Button btncontacto;
        private System.Windows.Forms.Button btnubicacion;
        private System.Windows.Forms.Button btndocumento;
        private System.Windows.Forms.Button btnfotosvideos;
        private System.Windows.Forms.Button btncamara;
    }
}