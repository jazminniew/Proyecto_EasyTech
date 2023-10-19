
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class puntos
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnarchivos = new System.Windows.Forms.Button();
            this.btnsilenciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnvercontacto = new System.Windows.Forms.Button();
            this.btnmensajestemporales = new System.Windows.Forms.Button();
            this.btnfondopantalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(538, 136);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(223, 41);
            this.btnbuscar.TabIndex = 32;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnarchivos
            // 
            this.btnarchivos.Location = new System.Drawing.Point(538, 100);
            this.btnarchivos.Name = "btnarchivos";
            this.btnarchivos.Size = new System.Drawing.Size(223, 41);
            this.btnarchivos.TabIndex = 31;
            this.btnarchivos.Text = "archivos, enclances y docs";
            this.btnarchivos.UseVisualStyleBackColor = true;
            this.btnarchivos.Click += new System.EventHandler(this.btnarchivos_Click);
            // 
            // btnsilenciar
            // 
            this.btnsilenciar.Location = new System.Drawing.Point(538, 173);
            this.btnsilenciar.Name = "btnsilenciar";
            this.btnsilenciar.Size = new System.Drawing.Size(223, 41);
            this.btnsilenciar.TabIndex = 29;
            this.btnsilenciar.Text = "silenciar";
            this.btnsilenciar.UseVisualStyleBackColor = true;
            this.btnsilenciar.Click += new System.EventHandler(this.btnsilenciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Toca el boton que creas que va a cumplir la funcion:";
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(538, 277);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(223, 41);
            this.btnmas.TabIndex = 33;
            this.btnmas.Text = "mas->";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnvercontacto
            // 
            this.btnvercontacto.Location = new System.Drawing.Point(538, 62);
            this.btnvercontacto.Name = "btnvercontacto";
            this.btnvercontacto.Size = new System.Drawing.Size(223, 41);
            this.btnvercontacto.TabIndex = 34;
            this.btnvercontacto.Text = "ver contactos";
            this.btnvercontacto.UseVisualStyleBackColor = true;
            // 
            // btnmensajestemporales
            // 
            this.btnmensajestemporales.Location = new System.Drawing.Point(538, 204);
            this.btnmensajestemporales.Name = "btnmensajestemporales";
            this.btnmensajestemporales.Size = new System.Drawing.Size(223, 41);
            this.btnmensajestemporales.TabIndex = 35;
            this.btnmensajestemporales.Text = "mensajes temporales";
            this.btnmensajestemporales.UseVisualStyleBackColor = true;
            // 
            // btnfondopantalla
            // 
            this.btnfondopantalla.Location = new System.Drawing.Point(538, 240);
            this.btnfondopantalla.Name = "btnfondopantalla";
            this.btnfondopantalla.Size = new System.Drawing.Size(223, 41);
            this.btnfondopantalla.TabIndex = 36;
            this.btnfondopantalla.Text = "fondo de pantalla";
            this.btnfondopantalla.UseVisualStyleBackColor = true;
            // 
            // puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfondopantalla);
            this.Controls.Add(this.btnmensajestemporales);
            this.Controls.Add(this.btnvercontacto);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnarchivos);
            this.Controls.Add(this.btnsilenciar);
            this.Controls.Add(this.label1);
            this.Name = "puntos";
            this.Text = "puntos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnarchivos;
        private System.Windows.Forms.Button btnsilenciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnvercontacto;
        private System.Windows.Forms.Button btnmensajestemporales;
        private System.Windows.Forms.Button btnfondopantalla;
    }
}