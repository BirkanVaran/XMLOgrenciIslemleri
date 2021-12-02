
namespace _4._3._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDTarihi = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.listBoxASinifi = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dateTimeDTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.listBoxBSinifi = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLileDisaAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLileIceAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnSagaGonder = new System.Windows.Forms.Button();
            this.btnHepsiniSagaGonder = new System.Windows.Forms.Button();
            this.btnSolaGonder = new System.Windows.Forms.Button();
            this.btnHepsiniSolaGonder = new System.Windows.Forms.Button();
            this.groupBoxOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.checkBoxSecmeliDers = new System.Windows.Forms.CheckBox();
            this.groupBoxSemeliDersler = new System.Windows.Forms.GroupBox();
            this.checkedListSecmeliDerslerListesi = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOgrenciBilgileri.SuspendLayout();
            this.groupBoxSemeliDersler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(36, 45);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Adı:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(14, 86);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(57, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyadı:";
            // 
            // lblDTarihi
            // 
            this.lblDTarihi.AutoSize = true;
            this.lblDTarihi.Location = new System.Drawing.Point(6, 129);
            this.lblDTarihi.Name = "lblDTarihi";
            this.lblDTarihi.Size = new System.Drawing.Size(65, 20);
            this.lblDTarihi.TabIndex = 2;
            this.lblDTarihi.Text = "D. Tarihi:";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(24, 168);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(45, 20);
            this.lblSinif.TabIndex = 3;
            this.lblSinif.Text = "Sınıfı:";
            // 
            // listBoxASinifi
            // 
            this.listBoxASinifi.FormattingEnabled = true;
            this.listBoxASinifi.ItemHeight = 20;
            this.listBoxASinifi.Location = new System.Drawing.Point(32, 306);
            this.listBoxASinifi.Name = "listBoxASinifi";
            this.listBoxASinifi.Size = new System.Drawing.Size(368, 184);
            this.listBoxASinifi.TabIndex = 4;
            this.listBoxASinifi.SelectedIndexChanged += new System.EventHandler(this.listBoxASinifi_SelectedIndexChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(86, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 27);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(86, 83);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 27);
            this.txtSoyad.TabIndex = 6;
            // 
            // dateTimeDTarihi
            // 
            this.dateTimeDTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDTarihi.Location = new System.Drawing.Point(86, 124);
            this.dateTimeDTarihi.Name = "dateTimeDTarihi";
            this.dateTimeDTarihi.Size = new System.Drawing.Size(250, 27);
            this.dateTimeDTarihi.TabIndex = 7;
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(86, 165);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(250, 28);
            this.comboBoxSinif.TabIndex = 8;
            this.comboBoxSinif.Text = "Sınıfınızı seçiniz...";
            // 
            // listBoxBSinifi
            // 
            this.listBoxBSinifi.FormattingEnabled = true;
            this.listBoxBSinifi.ItemHeight = 20;
            this.listBoxBSinifi.Location = new System.Drawing.Point(520, 306);
            this.listBoxBSinifi.Name = "listBoxBSinifi";
            this.listBoxBSinifi.Size = new System.Drawing.Size(402, 184);
            this.listBoxBSinifi.TabIndex = 9;
            this.listBoxBSinifi.SelectedIndexChanged += new System.EventHandler(this.listBoxBSinifi_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XMLileDisaAktarToolStripMenuItem,
            this.XMLileIceAktarToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // XMLileDisaAktarToolStripMenuItem
            // 
            this.XMLileDisaAktarToolStripMenuItem.Name = "XMLileDisaAktarToolStripMenuItem";
            this.XMLileDisaAktarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.XMLileDisaAktarToolStripMenuItem.Text = "XML ile dışa aktar";
            this.XMLileDisaAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLileDisaAktarToolStripMenuItem_Click);
            // 
            // XMLileIceAktarToolStripMenuItem
            // 
            this.XMLileIceAktarToolStripMenuItem.Name = "XMLileIceAktarToolStripMenuItem";
            this.XMLileIceAktarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.XMLileIceAktarToolStripMenuItem.Text = "XML ile içe aktar";
            this.XMLileIceAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLileIceAktarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(644, 21);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(160, 222);
            this.btnOgrenciEkle.TabIndex = 11;
            this.btnOgrenciEkle.Text = "ÖĞRENCİ EKLE";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnSagaGonder
            // 
            this.btnSagaGonder.Location = new System.Drawing.Point(429, 324);
            this.btnSagaGonder.Name = "btnSagaGonder";
            this.btnSagaGonder.Size = new System.Drawing.Size(63, 32);
            this.btnSagaGonder.TabIndex = 12;
            this.btnSagaGonder.Text = ">";
            this.btnSagaGonder.UseVisualStyleBackColor = true;
            this.btnSagaGonder.Click += new System.EventHandler(this.btnSagaGonder_Click);
            // 
            // btnHepsiniSagaGonder
            // 
            this.btnHepsiniSagaGonder.Location = new System.Drawing.Point(429, 362);
            this.btnHepsiniSagaGonder.Name = "btnHepsiniSagaGonder";
            this.btnHepsiniSagaGonder.Size = new System.Drawing.Size(63, 32);
            this.btnHepsiniSagaGonder.TabIndex = 13;
            this.btnHepsiniSagaGonder.Text = ">>";
            this.btnHepsiniSagaGonder.UseVisualStyleBackColor = true;
            this.btnHepsiniSagaGonder.Click += new System.EventHandler(this.btnHepsiniSagaGonder_Click);
            // 
            // btnSolaGonder
            // 
            this.btnSolaGonder.Location = new System.Drawing.Point(429, 402);
            this.btnSolaGonder.Name = "btnSolaGonder";
            this.btnSolaGonder.Size = new System.Drawing.Size(63, 32);
            this.btnSolaGonder.TabIndex = 14;
            this.btnSolaGonder.Text = "<";
            this.btnSolaGonder.UseVisualStyleBackColor = true;
            this.btnSolaGonder.Click += new System.EventHandler(this.btnSolaGonder_Click);
            // 
            // btnHepsiniSolaGonder
            // 
            this.btnHepsiniSolaGonder.Location = new System.Drawing.Point(429, 442);
            this.btnHepsiniSolaGonder.Name = "btnHepsiniSolaGonder";
            this.btnHepsiniSolaGonder.Size = new System.Drawing.Size(63, 32);
            this.btnHepsiniSolaGonder.TabIndex = 15;
            this.btnHepsiniSolaGonder.Text = "<<";
            this.btnHepsiniSolaGonder.UseVisualStyleBackColor = true;
            this.btnHepsiniSolaGonder.Click += new System.EventHandler(this.btnHepsiniSolaGonder_Click);
            // 
            // groupBoxOgrenciBilgileri
            // 
            this.groupBoxOgrenciBilgileri.Controls.Add(this.btnOgrenciEkle);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.checkBoxSecmeliDers);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.groupBoxSemeliDersler);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.txtAd);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.lblAd);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.lblSoyad);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.lblDTarihi);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.lblSinif);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.txtSoyad);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.dateTimeDTarihi);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.comboBoxSinif);
            this.groupBoxOgrenciBilgileri.Location = new System.Drawing.Point(32, 41);
            this.groupBoxOgrenciBilgileri.Name = "groupBoxOgrenciBilgileri";
            this.groupBoxOgrenciBilgileri.Size = new System.Drawing.Size(810, 249);
            this.groupBoxOgrenciBilgileri.TabIndex = 16;
            this.groupBoxOgrenciBilgileri.TabStop = false;
            this.groupBoxOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // checkBoxSecmeliDers
            // 
            this.checkBoxSecmeliDers.AutoSize = true;
            this.checkBoxSecmeliDers.Location = new System.Drawing.Point(64, 204);
            this.checkBoxSecmeliDers.Name = "checkBoxSecmeliDers";
            this.checkBoxSecmeliDers.Size = new System.Drawing.Size(272, 24);
            this.checkBoxSecmeliDers.TabIndex = 9;
            this.checkBoxSecmeliDers.Text = "Seçmeli ders almak istiyor musunuz?";
            this.checkBoxSecmeliDers.UseVisualStyleBackColor = true;
            this.checkBoxSecmeliDers.CheckedChanged += new System.EventHandler(this.checkBoxSecmeliDers_CheckedChanged);
            // 
            // groupBoxSemeliDersler
            // 
            this.groupBoxSemeliDersler.Controls.Add(this.checkedListSecmeliDerslerListesi);
            this.groupBoxSemeliDersler.Location = new System.Drawing.Point(342, 21);
            this.groupBoxSemeliDersler.Name = "groupBoxSemeliDersler";
            this.groupBoxSemeliDersler.Size = new System.Drawing.Size(296, 222);
            this.groupBoxSemeliDersler.TabIndex = 17;
            this.groupBoxSemeliDersler.TabStop = false;
            this.groupBoxSemeliDersler.Text = "Seçmeli Dersler";
            // 
            // checkedListSecmeliDerslerListesi
            // 
            this.checkedListSecmeliDerslerListesi.FormattingEnabled = true;
            this.checkedListSecmeliDerslerListesi.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Toplum Hizmeti",
            "İtalyanca",
            "Halk Sağlığı",
            "Evrim Teorisi"});
            this.checkedListSecmeliDerslerListesi.Location = new System.Drawing.Point(6, 26);
            this.checkedListSecmeliDerslerListesi.Name = "checkedListSecmeliDerslerListesi";
            this.checkedListSecmeliDerslerListesi.Size = new System.Drawing.Size(284, 180);
            this.checkedListSecmeliDerslerListesi.TabIndex = 0;
            this.checkedListSecmeliDerslerListesi.SelectedIndexChanged += new System.EventHandler(this.checkedListSecmeliDerslerListesi_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 504);
            this.Controls.Add(this.groupBoxOgrenciBilgileri);
            this.Controls.Add(this.btnHepsiniSolaGonder);
            this.Controls.Add(this.btnSolaGonder);
            this.Controls.Add(this.btnHepsiniSagaGonder);
            this.Controls.Add(this.btnSagaGonder);
            this.Controls.Add(this.listBoxBSinifi);
            this.Controls.Add(this.listBoxASinifi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOgrenciBilgileri.ResumeLayout(false);
            this.groupBoxOgrenciBilgileri.PerformLayout();
            this.groupBoxSemeliDersler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.ListBox listBoxASinifi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dateTimeDTarihi;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.ListBox listBoxBSinifi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnSagaGonder;
        private System.Windows.Forms.Button btnHepsiniSagaGonder;
        private System.Windows.Forms.Button btnSolaGonder;
        private System.Windows.Forms.Button btnHepsiniSolaGonder;
        private System.Windows.Forms.GroupBox groupBoxOgrenciBilgileri;
        private System.Windows.Forms.CheckBox checkBoxSecmeliDers;
        private System.Windows.Forms.GroupBox groupBoxSemeliDersler;
        private System.Windows.Forms.CheckedListBox checkedListSecmeliDerslerListesi;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLileDisaAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLileIceAktarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

