﻿
namespace PROYECTO_FINAL_TIC_3RO
{
    partial class camara
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
            this.btnfoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfoto
            // 
            this.btnfoto.Location = new System.Drawing.Point(315, 341);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(165, 61);
            this.btnfoto.TabIndex = 0;
            this.btnfoto.Text = "sacar foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfoto);
            this.Name = "camara";
            this.Text = "camara";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfoto;
    }
}