
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class homewspp
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnsticker = new System.Windows.Forms.Button();
            this.btncamara = new System.Windows.Forms.Button();
            this.btnaudio = new System.Windows.Forms.Button();
            this.btnvideollamada = new System.Windows.Forms.Button();
            this.btnllamada = new System.Windows.Forms.Button();
            this.btnnombre = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lbl1.Location = new System.Drawing.Point(114, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(601, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Toca el boton que creas que va a cumplir la funcion:";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(244, 381);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(54, 43);
            this.btnmas.TabIndex = 1;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnsticker
            // 
            this.btnsticker.Location = new System.Drawing.Point(460, 381);
            this.btnsticker.Name = "btnsticker";
            this.btnsticker.Size = new System.Drawing.Size(54, 43);
            this.btnsticker.TabIndex = 2;
            this.btnsticker.Text = "sticker";
            this.btnsticker.UseVisualStyleBackColor = true;
            this.btnsticker.Click += new System.EventHandler(this.btnsticker_Click);
            // 
            // btncamara
            // 
            this.btncamara.Location = new System.Drawing.Point(520, 381);
            this.btncamara.Name = "btncamara";
            this.btncamara.Size = new System.Drawing.Size(54, 43);
            this.btncamara.TabIndex = 3;
            this.btncamara.Text = "camara";
            this.btncamara.UseVisualStyleBackColor = true;
            this.btncamara.Click += new System.EventHandler(this.btncamara_Click);
            // 
            // btnaudio
            // 
            this.btnaudio.Location = new System.Drawing.Point(580, 381);
            this.btnaudio.Name = "btnaudio";
            this.btnaudio.Size = new System.Drawing.Size(54, 43);
            this.btnaudio.TabIndex = 4;
            this.btnaudio.Text = "audio";
            this.btnaudio.UseVisualStyleBackColor = true;
            this.btnaudio.Click += new System.EventHandler(this.btnaudio_Click);
            // 
            // btnvideollamada
            // 
            this.btnvideollamada.Location = new System.Drawing.Point(566, 91);
            this.btnvideollamada.Name = "btnvideollamada";
            this.btnvideollamada.Size = new System.Drawing.Size(54, 43);
            this.btnvideollamada.TabIndex = 5;
            this.btnvideollamada.Text = "videollamada";
            this.btnvideollamada.UseVisualStyleBackColor = true;
            this.btnvideollamada.Click += new System.EventHandler(this.btnvideollamada_Click);
            // 
            // btnllamada
            // 
            this.btnllamada.Location = new System.Drawing.Point(506, 91);
            this.btnllamada.Name = "btnllamada";
            this.btnllamada.Size = new System.Drawing.Size(54, 43);
            this.btnllamada.TabIndex = 6;
            this.btnllamada.Text = "llamada";
            this.btnllamada.UseVisualStyleBackColor = true;
            this.btnllamada.Click += new System.EventHandler(this.btnllamada_Click);
            // 
            // btnnombre
            // 
            this.btnnombre.Location = new System.Drawing.Point(304, 91);
            this.btnnombre.Name = "btnnombre";
            this.btnnombre.Size = new System.Drawing.Size(196, 43);
            this.btnnombre.TabIndex = 7;
            this.btnnombre.Text = "nombre/persona";
            this.btnnombre.UseVisualStyleBackColor = true;
            this.btnnombre.Click += new System.EventHandler(this.btnnombre_Click);
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(244, 91);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(54, 43);
            this.btnatras.TabIndex = 8;
            this.btnatras.Text = "volver atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // homewspp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.btnnombre);
            this.Controls.Add(this.btnllamada);
            this.Controls.Add(this.btnvideollamada);
            this.Controls.Add(this.btnaudio);
            this.Controls.Add(this.btncamara);
            this.Controls.Add(this.btnsticker);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.lbl1);
            this.Name = "homewspp";
            this.Text = "xx";
            this.Load += new System.EventHandler(this.WS_videollamada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnsticker;
        private System.Windows.Forms.Button btncamara;
        private System.Windows.Forms.Button btnaudio;
        private System.Windows.Forms.Button btnvideollamada;
        private System.Windows.Forms.Button btnllamada;
        private System.Windows.Forms.Button btnnombre;
        private System.Windows.Forms.Button btnatras;
    }
}