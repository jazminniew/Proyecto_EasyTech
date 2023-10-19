
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class enclances
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
            this.docs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // docs
            // 
            this.docs.Location = new System.Drawing.Point(524, 86);
            this.docs.Name = "docs";
            this.docs.Size = new System.Drawing.Size(107, 28);
            this.docs.TabIndex = 0;
            this.docs.Text = "docs";
            this.docs.UseVisualStyleBackColor = true;
            this.docs.Click += new System.EventHandler(this.docs_Click);
            // 
            // enclances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.docs);
            this.Name = "enclances";
            this.Text = "enclances";
            this.Load += new System.EventHandler(this.enclances_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button docs;
    }
}