
namespace pruebaeasytech3
{
    partial class fotosvideoss
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
            this.btnfotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfotos
            // 
            this.btnfotos.Location = new System.Drawing.Point(263, 55);
            this.btnfotos.Name = "btnfotos";
            this.btnfotos.Size = new System.Drawing.Size(284, 388);
            this.btnfotos.TabIndex = 0;
            this.btnfotos.Text = "fotos";
            this.btnfotos.UseVisualStyleBackColor = true;
            this.btnfotos.Click += new System.EventHandler(this.button1_Click);
            // 
            // fotosvideoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfotos);
            this.Name = "fotosvideoss";
            this.Text = "fotos";
            this.Load += new System.EventHandler(this.fotosvideoss_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfotos;
    }
}