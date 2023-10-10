
namespace pruebaeasytech3
{
    partial class seleccionardocumento
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
            this.btnabrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(495, 61);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(75, 23);
            this.btnabrir.TabIndex = 0;
            this.btnabrir.Text = "abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // seleccionardocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnabrir);
            this.Name = "seleccionardocumento";
            this.Text = "seleccionardocumento";
            this.Load += new System.EventHandler(this.seleccionardocumento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnabrir;
    }
}