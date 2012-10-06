namespace KurbanYazilimi
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hissedarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurbanıDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeİptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teknikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurbanEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kurbanTipleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurbanSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLisans = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniHisseKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÖdemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hisseDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hissedarToolStripMenuItem,
            this.faturaToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.yönetimToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hissedarToolStripMenuItem
            // 
            this.hissedarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriEkleToolStripMenuItem,
            this.kurbanıDeğiştirToolStripMenuItem,
            this.müşteriListesiToolStripMenuItem,
            this.müşteriBilgiDüzenleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem});
            this.hissedarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hissedarToolStripMenuItem.Image")));
            this.hissedarToolStripMenuItem.Name = "hissedarToolStripMenuItem";
            this.hissedarToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.hissedarToolStripMenuItem.Text = "Müşteri";
            // 
            // yeniMüşteriEkleToolStripMenuItem
            // 
            this.yeniMüşteriEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniMüşteriEkleToolStripMenuItem.Image")));
            this.yeniMüşteriEkleToolStripMenuItem.Name = "yeniMüşteriEkleToolStripMenuItem";
            this.yeniMüşteriEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniMüşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.yeniMüşteriEkleToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniMüşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşteriEkleToolStripMenuItem_Click);
            // 
            // kurbanıDeğiştirToolStripMenuItem
            // 
            this.kurbanıDeğiştirToolStripMenuItem.Name = "kurbanıDeğiştirToolStripMenuItem";
            this.kurbanıDeğiştirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.kurbanıDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.kurbanıDeğiştirToolStripMenuItem.Text = "Hisse Sil";
            this.kurbanıDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.kurbanıDeğiştirToolStripMenuItem_Click);
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşteriListesiToolStripMenuItem.Image")));
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // müşteriBilgiDüzenleToolStripMenuItem
            // 
            this.müşteriBilgiDüzenleToolStripMenuItem.Name = "müşteriBilgiDüzenleToolStripMenuItem";
            this.müşteriBilgiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.müşteriBilgiDüzenleToolStripMenuItem.Text = "Kişisel Bilgi Düzenle";
            this.müşteriBilgiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgiDüzenleToolStripMenuItem_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriSilToolStripMenuItem_Click);
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFaturaToolStripMenuItem,
            this.ödemeİptalToolStripMenuItem});
            this.faturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("faturaToolStripMenuItem.Image")));
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.faturaToolStripMenuItem.Text = "Fatura";
            // 
            // yeniFaturaToolStripMenuItem
            // 
            this.yeniFaturaToolStripMenuItem.Name = "yeniFaturaToolStripMenuItem";
            this.yeniFaturaToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.yeniFaturaToolStripMenuItem.Text = "Yeni Tahsilat";
            this.yeniFaturaToolStripMenuItem.Click += new System.EventHandler(this.yeniFaturaToolStripMenuItem_Click);
            // 
            // ödemeİptalToolStripMenuItem
            // 
            this.ödemeİptalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ödemeİptalToolStripMenuItem.Image")));
            this.ödemeİptalToolStripMenuItem.Name = "ödemeİptalToolStripMenuItem";
            this.ödemeİptalToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.ödemeİptalToolStripMenuItem.Text = "Tahsilat İptal";
            this.ödemeİptalToolStripMenuItem.Click += new System.EventHandler(this.ödemeİptalToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem,
            this.teknikToolStripMenuItem});
            this.yardımToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yardımToolStripMenuItem.Image")));
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // teknikToolStripMenuItem
            // 
            this.teknikToolStripMenuItem.Name = "teknikToolStripMenuItem";
            this.teknikToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.teknikToolStripMenuItem.Text = "Teknik";
            this.teknikToolStripMenuItem.Click += new System.EventHandler(this.teknikToolStripMenuItem_Click);
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurbanToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem});
            this.yönetimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yönetimToolStripMenuItem.Image")));
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // kurbanToolStripMenuItem
            // 
            this.kurbanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurbanEkleToolStripMenuItem1,
            this.kurbanTipleriToolStripMenuItem,
            this.kurbanSilToolStripMenuItem});
            this.kurbanToolStripMenuItem.Name = "kurbanToolStripMenuItem";
            this.kurbanToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.kurbanToolStripMenuItem.Text = "Kurban";
            // 
            // kurbanEkleToolStripMenuItem1
            // 
            this.kurbanEkleToolStripMenuItem1.Name = "kurbanEkleToolStripMenuItem1";
            this.kurbanEkleToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.kurbanEkleToolStripMenuItem1.Text = "Kurban Ekle";
            this.kurbanEkleToolStripMenuItem1.Click += new System.EventHandler(this.kurbanEkleToolStripMenuItem1_Click);
            // 
            // kurbanTipleriToolStripMenuItem
            // 
            this.kurbanTipleriToolStripMenuItem.Name = "kurbanTipleriToolStripMenuItem";
            this.kurbanTipleriToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.kurbanTipleriToolStripMenuItem.Text = "Kurban Tipleri";
            this.kurbanTipleriToolStripMenuItem.Click += new System.EventHandler(this.kurbanTipleriToolStripMenuItem_Click_1);
            // 
            // kurbanSilToolStripMenuItem
            // 
            this.kurbanSilToolStripMenuItem.Name = "kurbanSilToolStripMenuItem";
            this.kurbanSilToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.kurbanSilToolStripMenuItem.Text = "Kurban Sil";
            this.kurbanSilToolStripMenuItem.Click += new System.EventHandler(this.kurbanSilToolStripMenuItem_Click_1);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.şifreDeğiştirToolStripMenuItem.Text = "Güvenlik";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // lblLisans
            // 
            this.lblLisans.AutoSize = true;
            this.lblLisans.BackColor = System.Drawing.Color.White;
            this.lblLisans.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLisans.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblLisans.Location = new System.Drawing.Point(0, 687);
            this.lblLisans.Name = "lblLisans";
            this.lblLisans.Size = new System.Drawing.Size(10, 13);
            this.lblLisans.TabIndex = 3;
            this.lblLisans.Text = ".";
            this.lblLisans.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHisseKayıtToolStripMenuItem,
            this.yeniÖdemeToolStripMenuItem,
            this.hisseDeğiştirToolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 70);
            // 
            // yeniHisseKayıtToolStripMenuItem
            // 
            this.yeniHisseKayıtToolStripMenuItem.Name = "yeniHisseKayıtToolStripMenuItem";
            this.yeniHisseKayıtToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.yeniHisseKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniHisseKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniHisseKayıtToolStripMenuItem_Click);
            // 
            // yeniÖdemeToolStripMenuItem
            // 
            this.yeniÖdemeToolStripMenuItem.Name = "yeniÖdemeToolStripMenuItem";
            this.yeniÖdemeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.yeniÖdemeToolStripMenuItem.Text = "Yeni Tahsilat";
            this.yeniÖdemeToolStripMenuItem.Click += new System.EventHandler(this.yeniÖdemeToolStripMenuItem_Click);
            // 
            // hisseDeğiştirToolStripMenuItem
            // 
            this.hisseDeğiştirToolStripMenuItem.Name = "hisseDeğiştirToolStripMenuItem";
            this.hisseDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hisseDeğiştirToolStripMenuItem.Text = "Hisse Sil";
            this.hisseDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.hisseDeğiştirToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1027, 700);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblLisans);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Emine İnanç Vakfı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hissedarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgiDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurbanıDeğiştirToolStripMenuItem;
        private System.Windows.Forms.Label lblLisans;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniHisseKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÖdemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hisseDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurbanEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kurbanTipleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurbanSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teknikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeİptalToolStripMenuItem;
    }
}

