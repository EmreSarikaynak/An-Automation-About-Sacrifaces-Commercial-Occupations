namespace KurbanYazilimi
{
    partial class FormYeniOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYeniOdeme));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtCepTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMusteriNoAra = new System.Windows.Forms.TextBox();
            this.btnMusteriBul = new System.Windows.Forms.Button();
            this.lblUyari = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBeklenenOdeme = new System.Windows.Forms.TextBox();
            this.txtToplamOdenen = new System.Windows.Forms.TextBox();
            this.txtHisseNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNot2 = new System.Windows.Forms.Label();
            this.btnOdemeyiYap = new System.Windows.Forms.Button();
            this.txtOdemeMiktari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFaturaAciklamasi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKalanOdeme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Müşteri No :";
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
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1091, 301);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 69);
            this.btnExit.TabIndex = 39;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.txtCepTel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(37, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 102);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 181);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(37, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1105, 230);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşterinin Mevcut Hisseleri";
            // 
            // txtMusteriNoAra
            // 
            this.txtMusteriNoAra.Location = new System.Drawing.Point(230, 30);
            this.txtMusteriNoAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriNoAra.Name = "txtMusteriNoAra";
            this.txtMusteriNoAra.Size = new System.Drawing.Size(201, 23);
            this.txtMusteriNoAra.TabIndex = 41;
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriBul.BackgroundImage")));
            this.btnMusteriBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriBul.Location = new System.Drawing.Point(452, 23);
            this.btnMusteriBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(47, 37);
            this.btnMusteriBul.TabIndex = 39;
            this.btnMusteriBul.UseVisualStyleBackColor = true;
            this.btnMusteriBul.Click += new System.EventHandler(this.btnMusteriBul_Click);
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Location = new System.Drawing.Point(506, 36);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(12, 17);
            this.lblUyari.TabIndex = 44;
            this.lblUyari.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Hisse No :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtKalanOdeme);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtBeklenenOdeme);
            this.groupBox3.Controls.Add(this.txtToplamOdenen);
            this.groupBox3.Controls.Add(this.txtHisseNo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(821, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 220);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçilen Hisse Bilgileri";
            // 
            // txtBeklenenOdeme
            // 
            this.txtBeklenenOdeme.Location = new System.Drawing.Point(142, 114);
            this.txtBeklenenOdeme.Name = "txtBeklenenOdeme";
            this.txtBeklenenOdeme.ReadOnly = true;
            this.txtBeklenenOdeme.Size = new System.Drawing.Size(108, 23);
            this.txtBeklenenOdeme.TabIndex = 50;
            // 
            // txtToplamOdenen
            // 
            this.txtToplamOdenen.Location = new System.Drawing.Point(142, 75);
            this.txtToplamOdenen.Name = "txtToplamOdenen";
            this.txtToplamOdenen.ReadOnly = true;
            this.txtToplamOdenen.Size = new System.Drawing.Size(108, 23);
            this.txtToplamOdenen.TabIndex = 49;
            // 
            // txtHisseNo
            // 
            this.txtHisseNo.Location = new System.Drawing.Point(142, 30);
            this.txtHisseNo.Name = "txtHisseNo";
            this.txtHisseNo.ReadOnly = true;
            this.txtHisseNo.Size = new System.Drawing.Size(108, 23);
            this.txtHisseNo.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Hisse Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ödenen :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFaturaAciklamasi);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblNot2);
            this.groupBox4.Controls.Add(this.btnOdemeyiYap);
            this.groupBox4.Controls.Add(this.txtOdemeMiktari);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(37, 449);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(713, 199);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seçilen Hisse için Ödeme Alanı";
            // 
            // lblNot2
            // 
            this.lblNot2.AutoSize = true;
            this.lblNot2.Location = new System.Drawing.Point(31, 132);
            this.lblNot2.Name = "lblNot2";
            this.lblNot2.Size = new System.Drawing.Size(12, 17);
            this.lblNot2.TabIndex = 4;
            this.lblNot2.Text = ".";
            // 
            // btnOdemeyiYap
            // 
            this.btnOdemeyiYap.Location = new System.Drawing.Point(492, 132);
            this.btnOdemeyiYap.Name = "btnOdemeyiYap";
            this.btnOdemeyiYap.Size = new System.Drawing.Size(215, 51);
            this.btnOdemeyiYap.TabIndex = 2;
            this.btnOdemeyiYap.Text = "Ödemeyi Yap";
            this.btnOdemeyiYap.UseVisualStyleBackColor = true;
            this.btnOdemeyiYap.Click += new System.EventHandler(this.btnOdemeyiYap_Click);
            // 
            // txtOdemeMiktari
            // 
            this.txtOdemeMiktari.Location = new System.Drawing.Point(153, 42);
            this.txtOdemeMiktari.Name = "txtOdemeMiktari";
            this.txtOdemeMiktari.Size = new System.Drawing.Size(186, 23);
            this.txtOdemeMiktari.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ödeme Miktarı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Hisseyi seçmek için listede üzerine bir kez tıklayınız...";
            // 
            // txtFaturaAciklamasi
            // 
            this.txtFaturaAciklamasi.Location = new System.Drawing.Point(153, 93);
            this.txtFaturaAciklamasi.Multiline = true;
            this.txtFaturaAciklamasi.Name = "txtFaturaAciklamasi";
            this.txtFaturaAciklamasi.Size = new System.Drawing.Size(309, 90);
            this.txtFaturaAciklamasi.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fatura Açıklaması :";
            // 
            // txtKalanOdeme
            // 
            this.txtKalanOdeme.Location = new System.Drawing.Point(144, 153);
            this.txtKalanOdeme.Name = "txtKalanOdeme";
            this.txtKalanOdeme.ReadOnly = true;
            this.txtKalanOdeme.Size = new System.Drawing.Size(106, 23);
            this.txtKalanOdeme.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(31, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Kalan Ödeme :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(256, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "TL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(256, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "TL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(256, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "TL";
            // 
            // FormYeniOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 653);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMusteriNoAra);
            this.Controls.Add(this.btnMusteriBul);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormYeniOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Tahsilat";
            this.Load += new System.EventHandler(this.FormYeniOdeme_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtCepTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMusteriNoAra;
        private System.Windows.Forms.Button btnMusteriBul;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBeklenenOdeme;
        private System.Windows.Forms.TextBox txtToplamOdenen;
        private System.Windows.Forms.TextBox txtHisseNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOdemeyiYap;
        private System.Windows.Forms.TextBox txtOdemeMiktari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNot2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFaturaAciklamasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKalanOdeme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;

    }
}