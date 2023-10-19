
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class stickers
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
            this.btnstickers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstickers
            // 
            this.btnstickers.Location = new System.Drawing.Point(112, 184);
            this.btnstickers.Name = "btnstickers";
            this.btnstickers.Size = new System.Drawing.Size(556, 140);
            this.btnstickers.TabIndex = 0;
            this.btnstickers.Text = "stickers";
            this.btnstickers.UseVisualStyleBackColor = true;
            this.btnstickers.Click += new System.EventHandler(this.btnstickers_Click);
            // 
            // stickers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnstickers);
            this.Name = "stickers";
            this.Text = "stickers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstickers;
    }
}