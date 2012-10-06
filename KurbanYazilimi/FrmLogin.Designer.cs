namespace KurbanYazilimi
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUyari = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSifre = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKullaniciLogin = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSifre2 = new System.Windows.Forms.MaskedTextBox();
            this.lblUyari2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnYoneticiLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblNotum = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(163, 260);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 13);
            this.lblUyari.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 241);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSifre);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtKullaniciAdi);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnKullaniciLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KULLANICI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(253, 92);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(146, 26);
            this.txtSifre.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 112);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.helpProvider1.SetHelpString(this.txtKullaniciAdi, "\"user\"");
            this.txtKullaniciAdi.Location = new System.Drawing.Point(253, 50);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.helpProvider1.SetShowHelp(this.txtKullaniciAdi, true);
            this.txtKullaniciAdi.Size = new System.Drawing.Size(146, 26);
            this.txtKullaniciAdi.TabIndex = 15;
            this.txtKullaniciAdi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKullaniciAdi_MouseClick);
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(253, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKullaniciLogin
            // 
            this.btnKullaniciLogin.AutoEllipsis = true;
            this.btnKullaniciLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKullaniciLogin.Location = new System.Drawing.Point(332, 133);
            this.btnKullaniciLogin.Name = "btnKullaniciLogin";
            this.btnKullaniciLogin.Size = new System.Drawing.Size(67, 36);
            this.btnKullaniciLogin.TabIndex = 13;
            this.btnKullaniciLogin.Text = "Log in";
            this.btnKullaniciLogin.UseVisualStyleBackColor = true;
            this.btnKullaniciLogin.Click += new System.EventHandler(this.btnKullaniciLogin_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSifre2);
            this.tabPage2.Controls.Add(this.lblUyari2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtKullaniciAdi2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.btnYoneticiLogin);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "YÖNETİCİ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSifre2
            // 
            this.helpProvider1.SetHelpKeyword(this.txtSifre2, "");
            this.helpProvider1.SetHelpString(this.txtSifre2, "");
            this.txtSifre2.Location = new System.Drawing.Point(253, 92);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.PasswordChar = '*';
            this.helpProvider1.SetShowHelp(this.txtSifre2, true);
            this.txtSifre2.Size = new System.Drawing.Size(146, 26);
            this.txtSifre2.TabIndex = 28;
            // 
            // lblUyari2
            // 
            this.lblUyari2.AutoSize = true;
            this.lblUyari2.ForeColor = System.Drawing.Color.Red;
            this.lblUyari2.Location = new System.Drawing.Point(25, 175);
            this.lblUyari2.Name = "lblUyari2";
            this.lblUyari2.Size = new System.Drawing.Size(0, 20);
            this.lblUyari2.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(20, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 112);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi2
            // 
            this.helpProvider1.SetHelpString(this.txtKullaniciAdi2, "\"admin\"");
            this.txtKullaniciAdi2.Location = new System.Drawing.Point(253, 50);
            this.txtKullaniciAdi2.Name = "txtKullaniciAdi2";
            this.helpProvider1.SetShowHelp(this.txtKullaniciAdi2, true);
            this.txtKullaniciAdi2.Size = new System.Drawing.Size(146, 26);
            this.txtKullaniciAdi2.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(253, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 36);
            this.button3.TabIndex = 21;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnYoneticiLogin
            // 
            this.btnYoneticiLogin.AutoEllipsis = true;
            this.btnYoneticiLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYoneticiLogin.Location = new System.Drawing.Point(332, 133);
            this.btnYoneticiLogin.Name = "btnYoneticiLogin";
            this.btnYoneticiLogin.Size = new System.Drawing.Size(67, 36);
            this.btnYoneticiLogin.TabIndex = 20;
            this.btnYoneticiLogin.Text = "Log in";
            this.btnYoneticiLogin.UseVisualStyleBackColor = true;
            this.btnYoneticiLogin.Click += new System.EventHandler(this.btnYoneticiLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(13, 256);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 17);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblNotum
            // 
            this.lblNotum.AutoSize = true;
            this.lblNotum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotum.Location = new System.Drawing.Point(127, 256);
            this.lblNotum.Name = "lblNotum";
            this.lblNotum.Size = new System.Drawing.Size(0, 17);
            this.lblNotum.TabIndex = 30;
            // 
            // helpProvider1
            // 
            this.helpProvider1.Tag = "Recep";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 281);
            this.Controls.Add(this.lblNotum);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "FrmLogin";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTP | Güvenlik";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKullaniciLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciAdi2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnYoneticiLogin;
        private System.Windows.Forms.Label lblUyari2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblNotum;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MaskedTextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox txtSifre2;
    }
}