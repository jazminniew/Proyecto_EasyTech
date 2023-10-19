
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class silenciar
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
            this.btnsilenciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsilenciar
            // 
            this.btnsilenciar.Location = new System.Drawing.Point(241, 254);
            this.btnsilenciar.Name = "btnsilenciar";
            this.btnsilenciar.Size = new System.Drawing.Size(275, 184);
            this.btnsilenciar.TabIndex = 0;
            this.btnsilenciar.Text = "silenciar por...";
            this.btnsilenciar.UseVisualStyleBackColor = true;
            this.btnsilenciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // silenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsilenciar);
            this.Name = "silenciar";
            this.Text = "silenciar";
            this.Load += new System.EventHandler(this.silenciar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsilenciar;
    }
}