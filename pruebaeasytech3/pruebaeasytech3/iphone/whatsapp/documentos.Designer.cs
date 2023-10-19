
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class documentos
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
            this.btndocumentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndocumentos
            // 
            this.btndocumentos.Location = new System.Drawing.Point(245, 40);
            this.btndocumentos.Name = "btndocumentos";
            this.btndocumentos.Size = new System.Drawing.Size(282, 399);
            this.btndocumentos.TabIndex = 0;
            this.btndocumentos.Text = "DOCUMENTOS";
            this.btndocumentos.UseVisualStyleBackColor = true;
            this.btndocumentos.Click += new System.EventHandler(this.btndocumentos_Click);
            // 
            // documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndocumentos);
            this.Name = "documentos";
            this.Text = "documentos";
            this.Load += new System.EventHandler(this.documentos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndocumentos;
    }
}