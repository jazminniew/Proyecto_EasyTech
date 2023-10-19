
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class formincorrecto
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
            this.components = new System.ComponentModel.Container();
            this.lblincorrecto = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblincorrecto
            // 
            this.lblincorrecto.AutoSize = true;
            this.lblincorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F);
            this.lblincorrecto.Location = new System.Drawing.Point(111, 83);
            this.lblincorrecto.Name = "lblincorrecto";
            this.lblincorrecto.Size = new System.Drawing.Size(524, 120);
            this.lblincorrecto.TabIndex = 0;
            this.lblincorrecto.Text = "incorrecto";
            this.lblincorrecto.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formincorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblincorrecto);
            this.Name = "formincorrecto";
            this.Text = "formincorrecto";
            this.Load += new System.EventHandler(this.formincorrecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblincorrecto;
        private System.Windows.Forms.Timer timer1;
    }
}