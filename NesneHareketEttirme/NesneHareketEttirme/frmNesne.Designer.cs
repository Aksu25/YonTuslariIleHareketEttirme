
namespace NesneHareketEttirme
{
    partial class frmNesne
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
            this.pictureNesne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNesne)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureNesne
            // 
            this.pictureNesne.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureNesne.Location = new System.Drawing.Point(296, 148);
            this.pictureNesne.Name = "pictureNesne";
            this.pictureNesne.Size = new System.Drawing.Size(136, 79);
            this.pictureNesne.TabIndex = 0;
            this.pictureNesne.TabStop = false;
            // 
            // frmNesne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureNesne);
            this.Name = "frmNesne";
            this.Text = "frmNesne";
            this.Load += new System.EventHandler(this.frmNesne_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNesne_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNesne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureNesne;
    }
}