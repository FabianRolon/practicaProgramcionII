﻿namespace FrmPrincipal
{
    partial class FrmPrincipal
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
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.btnImprimirReceta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(1, 0);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(798, 384);
            this.rtbSalidaDeTest.TabIndex = 0;
            this.rtbSalidaDeTest.Text = "";
            // 
            // btnImprimirReceta
            // 
            this.btnImprimirReceta.Location = new System.Drawing.Point(12, 390);
            this.btnImprimirReceta.Name = "btnImprimirReceta";
            this.btnImprimirReceta.Size = new System.Drawing.Size(776, 51);
            this.btnImprimirReceta.TabIndex = 1;
            this.btnImprimirReceta.Text = "Imprimir Receta";
            this.btnImprimirReceta.UseVisualStyleBackColor = true;
            this.btnImprimirReceta.Click += new System.EventHandler(this.btnImprimirReceta_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimirReceta);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
        private System.Windows.Forms.Button btnImprimirReceta;
    }
}