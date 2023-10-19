
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class guardarfoto
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
            this.btnguardarfoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguardarfoto
            // 
            this.btnguardarfoto.Location = new System.Drawing.Point(238, 284);
            this.btnguardarfoto.Name = "btnguardarfoto";
            this.btnguardarfoto.Size = new System.Drawing.Size(253, 147);
            this.btnguardarfoto.TabIndex = 0;
            this.btnguardarfoto.Text = "guardar foto por defecto, siempre o nunca";
            this.btnguardarfoto.UseVisualStyleBackColor = true;
            this.btnguardarfoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // guardarfoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguardarfoto);
            this.Name = "guardarfoto";
            this.Text = "guardarfoto";
            this.Load += new System.EventHandler(this.guardarfoto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnguardarfoto;
    }
}