
namespace pruebaeasytech3
{
    partial class ayuda
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
            this.lblayuda = new System.Windows.Forms.Label();
            this.btnentendi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblayuda
            // 
            this.lblayuda.AutoSize = true;
            this.lblayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.lblayuda.Location = new System.Drawing.Point(279, 144);
            this.lblayuda.Name = "lblayuda";
            this.lblayuda.Size = new System.Drawing.Size(258, 63);
            this.lblayuda.TabIndex = 0;
            this.lblayuda.Text = "AYUDA...";
            // 
            // btnentendi
            // 
            this.btnentendi.Location = new System.Drawing.Point(267, 355);
            this.btnentendi.Name = "btnentendi";
            this.btnentendi.Size = new System.Drawing.Size(270, 45);
            this.btnentendi.TabIndex = 17;
            this.btnentendi.Text = "YA ENTENDI";
            this.btnentendi.UseVisualStyleBackColor = true;
            this.btnentendi.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnentendi);
            this.Controls.Add(this.lblayuda);
            this.Name = "ayuda";
            this.Text = "ayuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblayuda;
        private System.Windows.Forms.Button btnentendi;
    }
}