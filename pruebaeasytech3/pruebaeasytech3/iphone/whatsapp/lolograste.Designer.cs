
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class lolograste
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
            this.lbllolograste = new System.Windows.Forms.Label();
            this.btnvuelvealprincipio = new System.Windows.Forms.Button();
            this.btnvuelveaintentarlo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllolograste
            // 
            this.lbllolograste.AutoSize = true;
            this.lbllolograste.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbllolograste.Location = new System.Drawing.Point(329, 36);
            this.lbllolograste.Name = "lbllolograste";
            this.lbllolograste.Size = new System.Drawing.Size(139, 29);
            this.lbllolograste.TabIndex = 0;
            this.lbllolograste.Text = "Lo lograste!";
            // 
            // btnvuelvealprincipio
            // 
            this.btnvuelvealprincipio.Location = new System.Drawing.Point(237, 216);
            this.btnvuelvealprincipio.Name = "btnvuelvealprincipio";
            this.btnvuelvealprincipio.Size = new System.Drawing.Size(308, 117);
            this.btnvuelvealprincipio.TabIndex = 1;
            this.btnvuelvealprincipio.Text = "vuelve al principio";
            this.btnvuelvealprincipio.UseVisualStyleBackColor = true;
            this.btnvuelvealprincipio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnvuelveaintentarlo
            // 
            this.btnvuelveaintentarlo.Location = new System.Drawing.Point(237, 93);
            this.btnvuelveaintentarlo.Name = "btnvuelveaintentarlo";
            this.btnvuelveaintentarlo.Size = new System.Drawing.Size(308, 117);
            this.btnvuelveaintentarlo.TabIndex = 2;
            this.btnvuelveaintentarlo.Text = "vuelve a intentarlo!";
            this.btnvuelveaintentarlo.UseVisualStyleBackColor = true;
            this.btnvuelveaintentarlo.Click += new System.EventHandler(this.btnvuelveaintentarlo_Click);
            // 
            // lolograste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvuelveaintentarlo);
            this.Controls.Add(this.btnvuelvealprincipio);
            this.Controls.Add(this.lbllolograste);
            this.Name = "lolograste";
            this.Text = "lolograste";
            this.Load += new System.EventHandler(this.lolograste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllolograste;
        private System.Windows.Forms.Button btnvuelvealprincipio;
        private System.Windows.Forms.Button btnvuelveaintentarlo;
    }
}