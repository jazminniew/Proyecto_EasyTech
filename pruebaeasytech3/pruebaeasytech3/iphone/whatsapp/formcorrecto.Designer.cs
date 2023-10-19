
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class formcorrecto
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
            this.lblcorrecto = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblcorrecto
            // 
            this.lblcorrecto.AutoSize = true;
            this.lblcorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblcorrecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblcorrecto.Location = new System.Drawing.Point(288, 176);
            this.lblcorrecto.Name = "lblcorrecto";
            this.lblcorrecto.Size = new System.Drawing.Size(155, 29);
            this.lblcorrecto.TabIndex = 0;
            this.lblcorrecto.Text = "CORRECTO";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formcorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcorrecto);
            this.Name = "formcorrecto";
            this.Text = "formcorrecto";
            this.Load += new System.EventHandler(this.formcorrecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcorrecto;
        private System.Windows.Forms.Timer timer1;
    }
}