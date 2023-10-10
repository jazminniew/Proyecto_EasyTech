
namespace pruebaeasytech3
{
    partial class bloquear
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
            this.btnbloquear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbloquear
            // 
            this.btnbloquear.Location = new System.Drawing.Point(273, 337);
            this.btnbloquear.Name = "btnbloquear";
            this.btnbloquear.Size = new System.Drawing.Size(215, 60);
            this.btnbloquear.TabIndex = 0;
            this.btnbloquear.Text = "bloquear";
            this.btnbloquear.UseVisualStyleBackColor = true;
            this.btnbloquear.Click += new System.EventHandler(this.button1_Click);
            // 
            // bloquear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbloquear);
            this.Name = "bloquear";
            this.Text = "bloquear";
            this.Load += new System.EventHandler(this.bloquear_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbloquear;
    }
}