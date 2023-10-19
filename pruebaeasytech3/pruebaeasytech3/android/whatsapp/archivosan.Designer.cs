
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class archivosan
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
            this.btnenclances = new System.Windows.Forms.Button();
            this.docs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnenclances
            // 
            this.btnenclances.Location = new System.Drawing.Point(422, 67);
            this.btnenclances.Name = "btnenclances";
            this.btnenclances.Size = new System.Drawing.Size(108, 22);
            this.btnenclances.TabIndex = 0;
            this.btnenclances.Text = "enclances";
            this.btnenclances.UseVisualStyleBackColor = true;
            this.btnenclances.Click += new System.EventHandler(this.btnenclances_Click);
            // 
            // docs
            // 
            this.docs.Location = new System.Drawing.Point(308, 67);
            this.docs.Name = "docs";
            this.docs.Size = new System.Drawing.Size(108, 22);
            this.docs.TabIndex = 1;
            this.docs.Text = "docs";
            this.docs.UseVisualStyleBackColor = true;
            this.docs.Click += new System.EventHandler(this.docs_Click);
            // 
            // archivosan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.docs);
            this.Controls.Add(this.btnenclances);
            this.Name = "archivosan";
            this.Text = "archivosan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnenclances;
        private System.Windows.Forms.Button docs;
    }
}