
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncomenzar = new System.Windows.Forms.Button();
            this.lbleasytech = new System.Windows.Forms.Label();
            this.pcblogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btncomenzar
            // 
            this.btncomenzar.Location = new System.Drawing.Point(243, 305);
            this.btncomenzar.Name = "btncomenzar";
            this.btncomenzar.Size = new System.Drawing.Size(279, 72);
            this.btncomenzar.TabIndex = 0;
            this.btncomenzar.Text = "COMENZAR";
            this.btncomenzar.UseVisualStyleBackColor = true;
            this.btncomenzar.Click += new System.EventHandler(this.btncomenzar_Click);
            // 
            // lbleasytech
            // 
            this.lbleasytech.AutoSize = true;
            this.lbleasytech.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleasytech.Location = new System.Drawing.Point(156, 200);
            this.lbleasytech.Name = "lbleasytech";
            this.lbleasytech.Size = new System.Drawing.Size(477, 91);
            this.lbleasytech.TabIndex = 1;
            this.lbleasytech.Text = "EASYTECH";
            // 
            // pcblogo
            // 
            this.pcblogo.Location = new System.Drawing.Point(131, 16);
            this.pcblogo.Name = "pcblogo";
            this.pcblogo.Size = new System.Drawing.Size(543, 184);
            this.pcblogo.TabIndex = 2;
            this.pcblogo.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcblogo);
            this.Controls.Add(this.lbleasytech);
            this.Controls.Add(this.btncomenzar);
            this.Name = "home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncomenzar;
        private System.Windows.Forms.Label lbleasytech;
        private System.Windows.Forms.PictureBox pcblogo;
    }
}

