namespace KurbanYazilimi
{
    partial class OdemeIptal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeIptal));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGridOdemeler = new System.Windows.Forms.DataGridView();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnMusteriBul = new System.Windows.Forms.Button();
            this.txtCepTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.txtMusteriNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOdemeler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, -113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(12, 23);
            this.textBox1.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtGridOdemeler);
            this.groupBox1.Location = new System.Drawing.Point(50, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 304);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapılan Ödemeler";
            // 
            // dtGridOdemeler
            // 
            this.dtGridOdemeler.AllowUserToAddRows = false;
            this.dtGridOdemeler.AllowUserToDeleteRows = false;
            this.dtGridOdemeler.AllowUserToResizeColumns = false;
            this.dtGridOdemeler.AllowUserToResizeRows = false;
            this.dtGridOdemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridOdemeler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOdemeler.Location = new System.Drawing.Point(18, 33);
            this.dtGridOdemeler.Margin = new System.Windows.Forms.Padding(5);
            this.dtGridOdemeler.MultiSelect = false;
            this.dtGridOdemeler.Name = "dtGridOdemeler";
            this.dtGridOdemeler.ReadOnly = true;
            this.dtGridOdemeler.RowHeadersVisible = false;
            this.dtGridOdemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridOdemeler.Size = new System.Drawing.Size(593, 245);
            this.dtGridOdemeler.TabIndex = 58;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(224, 99);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ReadOnly = true;
            this.txtAdres.Size = new System.Drawing.Size(317, 61);
            this.txtAdres.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Adres :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(224, 23);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ReadOnly = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(201, 23);
            this.txtAdSoyad.TabIndex = 39;
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriBul.BackgroundImage")));
            this.btnMusteriBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriBul.Location = new System.Drawing.Point(458, 35);
            this.btnMusteriBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(47, 37);
            this.btnMusteriBul.TabIndex = 56;
            this.btnMusteriBul.UseVisualStyleBackColor = true;
            this.btnMusteriBul.Click += new System.EventHandler(this.btnMusteriBul_Click);
            // 
            // txtCepTel
            // 
            this.txtCepTel.Location = new System.Drawing.Point(224, 62);
            this.txtCepTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.ReadOnly = true;
            this.txtCepTel.Size = new System.Drawing.Size(201, 23);
            this.txtCepTel.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cep Tel No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ad Soyad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblUyari);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.txtCepTel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(50, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 192);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(28, 168);
            this.lblUyari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(12, 17);
            this.lblUyari.TabIndex = 40;
            this.lblUyari.Text = ".";
            // 
            // txtMusteriNoAra
            // 
            this.txtMusteriNoAra.Location = new System.Drawing.Point(236, 42);
            this.txtMusteriNoAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNoAra.Name = "txtMusteriNoAra";
            this.txtMusteriNoAra.Size = new System.Drawing.Size(201, 23);
            this.txtMusteriNoAra.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Müşteri No :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 83);
            this.button1.TabIndex = 59;
            this.button1.Text = "Seçili Ödemeyi \r\n  İPTAL ET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdemeIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 593);
            this.Controls.Add(this.btnMusteriBul);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMusteriNoAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OdemeIptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Iptal";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOdemeler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGridOdemeler;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnMusteriBul;
        private System.Windows.Forms.TextBox txtCepTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.TextBox txtMusteriNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}