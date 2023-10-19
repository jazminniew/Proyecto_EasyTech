
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class welcome
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
            this.lblbienvenidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbienvenidos
            // 
            this.lblbienvenidos.AutoSize = true;
            this.lblbienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenidos.Location = new System.Drawing.Point(141, 40);
            this.lblbienvenidos.Name = "lblbienvenidos";
            this.lblbienvenidos.Size = new System.Drawing.Size(504, 91);
            this.lblbienvenidos.TabIndex = 2;
            this.lblbienvenidos.Text = "Bienvenidos!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(111, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Esta app va a servir para aprender a usar Instagram, Whatsapp y Configuracion";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(246, 274);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(279, 72);
            this.btnsiguiente.TabIndex = 4;
            this.btnsiguiente.Text = "SIGUIENTE";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbienvenidos);
            this.Name = "welcome";
            this.Text = "welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbienvenidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsiguiente;
    }
}