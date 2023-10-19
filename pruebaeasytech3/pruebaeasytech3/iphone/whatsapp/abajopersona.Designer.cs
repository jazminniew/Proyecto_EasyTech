
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class abajopersona
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
            this.btnvaciarchat = new System.Windows.Forms.Button();
            this.btnbloquear = new System.Windows.Forms.Button();
            this.btnflechaarriba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvaciarchat
            // 
            this.btnvaciarchat.Location = new System.Drawing.Point(248, 314);
            this.btnvaciarchat.Name = "btnvaciarchat";
            this.btnvaciarchat.Size = new System.Drawing.Size(264, 38);
            this.btnvaciarchat.TabIndex = 0;
            this.btnvaciarchat.Text = "vaciar chat";
            this.btnvaciarchat.UseVisualStyleBackColor = true;
            this.btnvaciarchat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbloquear
            // 
            this.btnbloquear.Location = new System.Drawing.Point(248, 375);
            this.btnbloquear.Name = "btnbloquear";
            this.btnbloquear.Size = new System.Drawing.Size(264, 38);
            this.btnbloquear.TabIndex = 1;
            this.btnbloquear.Text = "bloquear";
            this.btnbloquear.UseVisualStyleBackColor = true;
            this.btnbloquear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnflechaarriba
            // 
            this.btnflechaarriba.Location = new System.Drawing.Point(336, 12);
            this.btnflechaarriba.Name = "btnflechaarriba";
            this.btnflechaarriba.Size = new System.Drawing.Size(101, 38);
            this.btnflechaarriba.TabIndex = 2;
            this.btnflechaarriba.Text = "flecha arriba";
            this.btnflechaarriba.UseVisualStyleBackColor = true;
            this.btnflechaarriba.Click += new System.EventHandler(this.button3_Click);
            // 
            // abajopersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnflechaarriba);
            this.Controls.Add(this.btnbloquear);
            this.Controls.Add(this.btnvaciarchat);
            this.Name = "abajopersona";
            this.Text = "abajopersona";
            this.Load += new System.EventHandler(this.abajopersona_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvaciarchat;
        private System.Windows.Forms.Button btnbloquear;
        private System.Windows.Forms.Button btnflechaarriba;
    }
}