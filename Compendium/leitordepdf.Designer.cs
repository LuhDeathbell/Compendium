namespace Compendium
{
    partial class leitordepdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leitordepdf));
            this.SuspendLayout();
            // 
            // leitordepdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "leitordepdf";
            this.Text = "Leitor de PDF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.leitordepdf_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.leitordepdf_FormClosed);
            this.Load += new System.EventHandler(this.leitordepdf_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}