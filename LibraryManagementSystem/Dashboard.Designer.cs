namespace LibraryManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÖğrenciKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçAlınmışKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriGelmişKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapBilgisiDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.öğrenciToolStripMenuItem,
            this.ödünçAlınmışKitaplarToolStripMenuItem,
            this.geriGelmişKitaplarToolStripMenuItem,
            this.kitapBilgisiDetayToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKitapEkleToolStripMenuItem,
            this.kitaplarıGörüntüleToolStripMenuItem});
            this.kitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarToolStripMenuItem.Image")));
            this.kitaplarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(109, 54);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // yeniKitapEkleToolStripMenuItem
            // 
            this.yeniKitapEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniKitapEkleToolStripMenuItem.Image")));
            this.yeniKitapEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yeniKitapEkleToolStripMenuItem.Name = "yeniKitapEkleToolStripMenuItem";
            this.yeniKitapEkleToolStripMenuItem.Size = new System.Drawing.Size(207, 56);
            this.yeniKitapEkleToolStripMenuItem.Text = "Yeni Kitap Ekle";
            this.yeniKitapEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniKitapEkleToolStripMenuItem_Click);
            // 
            // kitaplarıGörüntüleToolStripMenuItem
            // 
            this.kitaplarıGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarıGörüntüleToolStripMenuItem.Image")));
            this.kitaplarıGörüntüleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitaplarıGörüntüleToolStripMenuItem.Name = "kitaplarıGörüntüleToolStripMenuItem";
            this.kitaplarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(207, 56);
            this.kitaplarıGörüntüleToolStripMenuItem.Text = "Kitapları Görüntüle";
            this.kitaplarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.kitaplarıGörüntüleToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÖğrenciKaydıToolStripMenuItem,
            this.öğrenciBilgisiToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciToolStripMenuItem.Image")));
            this.öğrenciToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(111, 54);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // yeniÖğrenciKaydıToolStripMenuItem
            // 
            this.yeniÖğrenciKaydıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniÖğrenciKaydıToolStripMenuItem.Image")));
            this.yeniÖğrenciKaydıToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yeniÖğrenciKaydıToolStripMenuItem.Name = "yeniÖğrenciKaydıToolStripMenuItem";
            this.yeniÖğrenciKaydıToolStripMenuItem.Size = new System.Drawing.Size(207, 56);
            this.yeniÖğrenciKaydıToolStripMenuItem.Text = "Yeni Öğrenci Kaydı";
            this.yeniÖğrenciKaydıToolStripMenuItem.Click += new System.EventHandler(this.yeniÖğrenciKaydıToolStripMenuItem_Click);
            // 
            // öğrenciBilgisiToolStripMenuItem
            // 
            this.öğrenciBilgisiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciBilgisiToolStripMenuItem.Image")));
            this.öğrenciBilgisiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.öğrenciBilgisiToolStripMenuItem.Name = "öğrenciBilgisiToolStripMenuItem";
            this.öğrenciBilgisiToolStripMenuItem.Size = new System.Drawing.Size(207, 56);
            this.öğrenciBilgisiToolStripMenuItem.Text = "Öğrenci Bilgisi";
            this.öğrenciBilgisiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciBilgisiToolStripMenuItem_Click);
            // 
            // ödünçAlınmışKitaplarToolStripMenuItem
            // 
            this.ödünçAlınmışKitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ödünçAlınmışKitaplarToolStripMenuItem.Image")));
            this.ödünçAlınmışKitaplarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ödünçAlınmışKitaplarToolStripMenuItem.Name = "ödünçAlınmışKitaplarToolStripMenuItem";
            this.ödünçAlınmışKitaplarToolStripMenuItem.Size = new System.Drawing.Size(185, 54);
            this.ödünçAlınmışKitaplarToolStripMenuItem.Text = "Ödünç Alınan Kitaplar";
            this.ödünçAlınmışKitaplarToolStripMenuItem.Click += new System.EventHandler(this.ödünçAlınmışKitaplarToolStripMenuItem_Click);
            // 
            // geriGelmişKitaplarToolStripMenuItem
            // 
            this.geriGelmişKitaplarToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.geriGelmişKitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geriGelmişKitaplarToolStripMenuItem.Image")));
            this.geriGelmişKitaplarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.geriGelmişKitaplarToolStripMenuItem.Name = "geriGelmişKitaplarToolStripMenuItem";
            this.geriGelmişKitaplarToolStripMenuItem.Size = new System.Drawing.Size(166, 54);
            this.geriGelmişKitaplarToolStripMenuItem.Text = "Geri Gelen Kitaplar";
            this.geriGelmişKitaplarToolStripMenuItem.Click += new System.EventHandler(this.geriGelmişKitaplarToolStripMenuItem_Click);
            // 
            // kitapBilgisiDetayToolStripMenuItem
            // 
            this.kitapBilgisiDetayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapBilgisiDetayToolStripMenuItem.Image")));
            this.kitapBilgisiDetayToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitapBilgisiDetayToolStripMenuItem.Name = "kitapBilgisiDetayToolStripMenuItem";
            this.kitapBilgisiDetayToolStripMenuItem.Size = new System.Drawing.Size(163, 54);
            this.kitapBilgisiDetayToolStripMenuItem.Text = "Kitap Bilgisi Detay";
            this.kitapBilgisiDetayToolStripMenuItem.Click += new System.EventHandler(this.kitapBilgisiDetayToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(94, 54);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 449);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kitaplarToolStripMenuItem;
        private ToolStripMenuItem yeniKitapEkleToolStripMenuItem;
        private ToolStripMenuItem kitaplarıGörüntüleToolStripMenuItem;
        private ToolStripMenuItem öğrenciToolStripMenuItem;
        private ToolStripMenuItem yeniÖğrenciKaydıToolStripMenuItem;
        private ToolStripMenuItem öğrenciBilgisiToolStripMenuItem;
        private ToolStripMenuItem ödünçAlınmışKitaplarToolStripMenuItem;
        private ToolStripMenuItem geriGelmişKitaplarToolStripMenuItem;
        private ToolStripMenuItem kitapBilgisiDetayToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}