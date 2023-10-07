namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    partial class SekreterMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaKayıtEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtEkranıToolStripMenuItem,
            this.ilaçİşlemleriToolStripMenuItem,
            this.sıraToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaKayıtEkranıToolStripMenuItem
            // 
            this.hastaKayıtEkranıToolStripMenuItem.Name = "hastaKayıtEkranıToolStripMenuItem";
            this.hastaKayıtEkranıToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.hastaKayıtEkranıToolStripMenuItem.Text = "Hasta Kayıt Ekranı";
            this.hastaKayıtEkranıToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtEkranıToolStripMenuItem_Click);
            // 
            // ilaçİşlemleriToolStripMenuItem
            // 
            this.ilaçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçEkleToolStripMenuItem,
            this.ilaçListeleToolStripMenuItem});
            this.ilaçİşlemleriToolStripMenuItem.Name = "ilaçİşlemleriToolStripMenuItem";
            this.ilaçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.ilaçİşlemleriToolStripMenuItem.Text = "İlaç İşlemleri";
            // 
            // ilaçEkleToolStripMenuItem
            // 
            this.ilaçEkleToolStripMenuItem.Name = "ilaçEkleToolStripMenuItem";
            this.ilaçEkleToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.ilaçEkleToolStripMenuItem.Text = "İlaç Ekle";
            this.ilaçEkleToolStripMenuItem.Click += new System.EventHandler(this.ilaçEkleToolStripMenuItem_Click);
            // 
            // ilaçListeleToolStripMenuItem
            // 
            this.ilaçListeleToolStripMenuItem.Name = "ilaçListeleToolStripMenuItem";
            this.ilaçListeleToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.ilaçListeleToolStripMenuItem.Text = "İlaç Listele";
            this.ilaçListeleToolStripMenuItem.Click += new System.EventHandler(this.ilaçListeleToolStripMenuItem_Click);
            // 
            // sıraToolStripMenuItem
            // 
            this.sıraToolStripMenuItem.Name = "sıraToolStripMenuItem";
            this.sıraToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.sıraToolStripMenuItem.Text = "Reçeteleri Listele";
            this.sıraToolStripMenuItem.Click += new System.EventHandler(this.sıraToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // SekreterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 598);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SekreterMenu";
            this.Text = "SekreterMenu";
            this.Load += new System.EventHandler(this.SekreterMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}