
namespace pruebaeasytech3
{
    partial class tocafondo
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
            this.btnfondos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfondos
            // 
            this.btnfondos.Location = new System.Drawing.Point(275, 86);
            this.btnfondos.Name = "btnfondos";
            this.btnfondos.Size = new System.Drawing.Size(277, 348);
            this.btnfondos.TabIndex = 0;
            this.btnfondos.Text = "fondos";
            this.btnfondos.UseVisualStyleBackColor = true;
            this.btnfondos.Click += new System.EventHandler(this.button1_Click);
            // 
            // tocafondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfondos);
            this.Name = "tocafondo";
            this.Text = "tocafondo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfondos;
    }
}