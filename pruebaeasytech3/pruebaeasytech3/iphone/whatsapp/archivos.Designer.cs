
namespace pruebaeasytech3
{
    partial class archivos
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
            this.SuspendLayout();
            // 
            // btnenclances
            // 
            this.btnenclances.Location = new System.Drawing.Point(308, 92);
            this.btnenclances.Name = "btnenclances";
            this.btnenclances.Size = new System.Drawing.Size(130, 27);
            this.btnenclances.TabIndex = 0;
            this.btnenclances.Text = "enclances";
            this.btnenclances.UseVisualStyleBackColor = true;
            this.btnenclances.Click += new System.EventHandler(this.btnenclances_Click);
            // 
            // archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnenclances);
            this.Name = "archivos";
            this.Text = "archivos";
            this.Load += new System.EventHandler(this.archivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnenclances;
    }
}