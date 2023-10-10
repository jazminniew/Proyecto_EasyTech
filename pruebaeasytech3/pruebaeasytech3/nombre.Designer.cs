
namespace pruebaeasytech3
{
    partial class nombre
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
            this.btnllamada = new System.Windows.Forms.Button();
            this.btnvideollamada = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnllamada
            // 
            this.btnllamada.Location = new System.Drawing.Point(260, 81);
            this.btnllamada.Name = "btnllamada";
            this.btnllamada.Size = new System.Drawing.Size(51, 43);
            this.btnllamada.TabIndex = 0;
            this.btnllamada.Text = "llamada";
            this.btnllamada.UseVisualStyleBackColor = true;
            this.btnllamada.Click += new System.EventHandler(this.btnllamada_Click);
            // 
            // btnvideollamada
            // 
            this.btnvideollamada.Location = new System.Drawing.Point(350, 81);
            this.btnvideollamada.Name = "btnvideollamada";
            this.btnvideollamada.Size = new System.Drawing.Size(51, 43);
            this.btnvideollamada.TabIndex = 1;
            this.btnvideollamada.Text = "videollamada";
            this.btnvideollamada.UseVisualStyleBackColor = true;
            this.btnvideollamada.Click += new System.EventHandler(this.btnvideollamada_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "enclances, archivos y docs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(260, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "silenciar notificaciones";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 33);
            this.button6.TabIndex = 5;
            this.button6.Text = "personalizar notificaciones";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(260, 259);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(224, 33);
            this.button8.TabIndex = 7;
            this.button8.Text = "visibilidad de archivos";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(334, 310);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 56);
            this.button11.TabIndex = 12;
            this.button11.Text = "--->";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnvideollamada);
            this.Controls.Add(this.btnllamada);
            this.Name = "nombre";
            this.Text = "destacadosan";
            this.Load += new System.EventHandler(this.nombre_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnllamada;
        private System.Windows.Forms.Button btnvideollamada;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
    }
}