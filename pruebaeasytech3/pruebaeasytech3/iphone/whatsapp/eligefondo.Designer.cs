
namespace pruebaeasytech3
{
    partial class eligefondo
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
            this.btnfondopantalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfondopantalla
            // 
            this.btnfondopantalla.Location = new System.Drawing.Point(261, 138);
            this.btnfondopantalla.Name = "btnfondopantalla";
            this.btnfondopantalla.Size = new System.Drawing.Size(260, 72);
            this.btnfondopantalla.TabIndex = 0;
            this.btnfondopantalla.Text = "elije un fondo de pantalla";
            this.btnfondopantalla.UseVisualStyleBackColor = true;
            this.btnfondopantalla.Click += new System.EventHandler(this.button1_Click);
            // 
            // eligefondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfondopantalla);
            this.Name = "eligefondo";
            this.Text = "eligefondo";
            this.Load += new System.EventHandler(this.eligefondo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfondopantalla;
    }
}