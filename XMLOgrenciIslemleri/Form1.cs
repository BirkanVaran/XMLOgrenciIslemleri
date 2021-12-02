using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _4._3._3
{
    public partial class Form1 : Form
    {
        #region Global Alan

        List<string> SiniflarListesi = new List<string>() { "A Sınıfı", "B Sınıfı" };
        List<Ogrenci> ASinifiOgrencileri = new List<Ogrenci>();
        List<Ogrenci> BSinifiOgrencileri = new List<Ogrenci>();
        List<string> SecilenSecmeliDersler = new List<string>();

        #endregion


        public Form1()
        {


            InitializeComponent();

            /*AddRange ile de eklenebilir.
             * AddRange içeriye dizi, yani array ister.
             * Bu nedenle liste, ToArray ile diziye çevilmeli.
             * comboBoxSinif.Items.AddRange(SiniflarListesi.ToArray()); */

            // Ya da döngü ile eklenebilir:
            foreach (var item in SiniflarListesi)
            {
                comboBoxSinif.Items.Add(item);
            }
            txtAd.TabIndex = 0;
            txtSoyad.TabIndex = 1;
            dateTimeDTarihi.TabIndex = 2;
            comboBoxSinif.TabIndex = 3;
            checkBoxSecmeliDers.TabIndex = 4;
            checkedListSecmeliDerslerListesi.TabIndex = 5;
            btnOgrenciEkle.TabIndex = 6;
            listBoxASinifi.TabIndex = 7;
            listBoxBSinifi.TabIndex = 8;
            btnHepsiniSolaGonder.Enabled = false;
            btnSolaGonder.Enabled = false;
            btnSagaGonder.Enabled = false;
            btnHepsiniSagaGonder.Enabled = false;

            groupBoxSemeliDersler.Enabled = false;

            checkedListSecmeliDerslerListesi.CheckOnClick = true; // CheckOnClick - ilk tıkta tiklensin.
        }
        private bool ASinifindaAynıOgrenciVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in ASinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }

            }
            return sonuc;
        }
        private bool BSinifindaAynıOgrenciVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in BSinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }

            }
            return sonuc;
        }
        private void KontrolleriTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = string.Empty;
            comboBoxSinif.SelectedIndex = -1;
            comboBoxSinif.Text = default;
            dateTimeDTarihi.Value = DateTime.Now;
            checkBoxSecmeliDers.Checked = default;

            //CheckedListSecmeliDerslerListesi içindeki tik atılmış dersleri temizleyelim:
            foreach (int index in checkedListSecmeliDerslerListesi.CheckedIndices)
            {
                checkedListSecmeliDerslerListesi.SetItemCheckState(index, CheckState.Unchecked);
            };
            SecilenSecmeliDersler.Clear();
            groupBoxSemeliDersler.Enabled = false;


        }
        private void ListeleriDoldur()
        {
            listBoxASinifi.Items.Clear();
            listBoxASinifi.BackColor = Color.Chartreuse;
            listBoxASinifi.Items.AddRange(ASinifiOgrencileri.ToArray());

            listBoxBSinifi.Items.Clear();
            listBoxBSinifi.BackColor = Color.DarkOrange;
            listBoxBSinifi.Items.AddRange(BSinifiOgrencileri.ToArray());
        }
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            // Öğrenci ekleyelim:
            /* string.IsNullOrEmpty ---> Hazır bir string metottur.
             * İçine verilen değerin null ya da boş olup olmadığını kontrol eder. */
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Öğrenci adı ve/veya soyadı boş olmamalıdır.");
            }
            else
            {
                Ogrenci ogr1 = new Ogrenci
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DTarihi = dateTimeDTarihi.Value
                };

                //if (ASinifindaAynıOgrenciVarMi(ogr1))
                //{
                //    MessageBox.Show("Öğrenci A sınıfı listesinde bulunuyor.");

                //}
                //else if (BSinifindaAynıOgrenciVarMi(ogr1))
                //{
                //    MessageBox.Show("Öğrenci B sınıfı listesinde bulunuyor.");

                //}
                // ComboBox'ta seçtiği değer:
                /*else*/
                if (comboBoxSinif.SelectedIndex >= 0)
                {
                    // Öğrencinin sınıfı ComoboBox'tan gelen seçili değer olacak.
                    ogr1.Sinif = comboBoxSinif.SelectedItem.ToString();

                    // Öğrenciyi listBox'a ekleyelim:
                    switch (comboBoxSinif.SelectedIndex)
                    {
                        case 0:
                            if (!ASinifindaAynıOgrenciVarMi(ogr1))
                            {

                                ////ASinifiOgrencileri.Add(ogr1);
                                if (BSinifindaAynıOgrenciVarMi(ogr1))
                                {
                                    MessageBox.Show("Öğrenci A sınıfı listesinde bulunuyor.");
                                }
                                else
                                {
                                    ASinifiOgrencileri.Add(ogr1);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        case 1:
                            if (!BSinifindaAynıOgrenciVarMi(ogr1))
                            {
                                //BSinifiOgrencileri.Add(ogr1);
                                if (ASinifindaAynıOgrenciVarMi(ogr1))
                                {
                                    MessageBox.Show("Öğrenci A sınıfı listesinde bulunuyor.");
                                }
                                else
                                {
                                    BSinifiOgrencileri.Add(ogr1);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        default:
                            break;
                    }

                    // Öğrenci seçmeli ders alıyorsa, listesine bu dersleri ekleyelim:
                    ogr1.SecmeliDersAliyorMu = checkBoxSecmeliDers.Checked;
                    if (ogr1.SecmeliDersAliyorMu)
                    {
                        ogr1.AldigiSecmeliDersler.AddRange(SecilenSecmeliDersler);
                    }
                    KontrolleriTemizle();
                    ListeleriDoldur();
                }
                else
                {
                    MessageBox.Show("Sınıf seçimi yapılmalıdır.");
                }

            }
        }

        private void btnHepsiniSagaGonder_Click(object sender, EventArgs e)
        {
            foreach (var item in ASinifiOgrencileri)
            {
                item.Sinif = "B sınıfı";
            }
            BSinifiOgrencileri.AddRange(ASinifiOgrencileri.ToArray());
            ASinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void btnHepsiniSolaGonder_Click(object sender, EventArgs e)
        {
            foreach (var item in BSinifiOgrencileri)
            {
                item.Sinif = "A sınıfı";
            }
            ASinifiOgrencileri.AddRange(BSinifiOgrencileri.ToArray());
            BSinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void btnSagaGonder_Click(object sender, EventArgs e)
        {
            Ogrenci ogrTransfer = listBoxASinifi.SelectedItem as Ogrenci;
            //Ogrenci ogrTransfer = (Ogrenci)listBoxASinifi.SelectedItem;  // Cast işlemi, ikisi de olur.
            if (ogrTransfer != null)
            {
                ASinifiOgrencileri.Remove(ogrTransfer);
                ogrTransfer.Sinif = "B sınıfı";
                BSinifiOgrencileri.Add(ogrTransfer);
                ListeleriDoldur();
            }



        }

        private void btnSolaGonder_Click(object sender, EventArgs e)
        {
            Ogrenci ogrTransfer = listBoxBSinifi.SelectedItem as Ogrenci;
            //Ogrenci ogrTransfer = (Ogrenci)listBoxASinifi.SelectedItem;  // Cast işlemi, ikisi de olur.
            if (ogrTransfer != null)
            {
                BSinifiOgrencileri.Remove(ogrTransfer);
                ogrTransfer.Sinif = "A sınıfı";
                ASinifiOgrencileri.Add(ogrTransfer);
                ListeleriDoldur();
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxASinifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSolaGonder.Enabled = false;
            btnHepsiniSolaGonder.Enabled = false;
            btnSagaGonder.Enabled = true;
            btnHepsiniSagaGonder.Enabled = true;
        }

        private void listBoxBSinifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSolaGonder.Enabled = true;
            btnHepsiniSolaGonder.Enabled = true;
            btnSagaGonder.Enabled = false;
            btnHepsiniSagaGonder.Enabled = false;
        }

        private void checkBoxSecmeliDers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecmeliDers.Checked)
            {
                groupBoxSemeliDersler.Enabled = true;
            }
            else
            {
                groupBoxSemeliDersler.Enabled = false;
            }
        }

        private void checkedListSecmeliDerslerListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenSecmeliDersler.Clear();
            foreach (var item in checkedListSecmeliDerslerListesi.CheckedItems)
            {

                /*Eğer SecilenSecmeliDersler listesinde bu ders varsa tekrar eklememesi için koşul yazalım.
                 * CheckedItem'sin */
                if (SecilenSecmeliDersler.Count(x => x == item.ToString())==0)
                {
                    SecilenSecmeliDersler.Add(item.ToString());
                }
            }
           
            //if (SecilenSecmeliDersler.Count(x==>) // Eğer SeçilenSecmeliDersler listesinde eklenmek istenen ders varsa, tekrar eklemesin.
            //{
            //SecilenSecmeliDersler.Add(checkedListSecmeliDerslerListesi.CheckedItems.ToString());

            //}
        }

        private void XMLileDisaAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ogrenci> DisariAktarilacaklar = new List<Ogrenci>();
            // A sınıfında öğrenci varsa:
            if (ASinifiOgrencileri.Count>0)
            {
                DisariAktarilacaklar.AddRange(ASinifiOgrencileri);
            }
            if (BSinifiOgrencileri.Count>0)
            {
                DisariAktarilacaklar.AddRange(BSinifiOgrencileri);
            }

            //Oluşturulacak XML dosyasının kaydedileceği konum için DİYALOG nesnesine ihyitaç var.
            

            saveFileDialog1.Title = "Öğrenci XML Dosyası Kaydet";
            saveFileDialog1.Filter = "XML Formatı | *xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                // Açılan diyalog penceresinde OK tuşuna basıldığında XML dosyasını oluşturabiliriz.
                //XML'i seriliaze edecek işlemler:
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));

                /*Bu yazımda C#’ta using bloğundan bahsedeceğim.
                 * IDisposable interface inden türemiş nesneler using(){} bloğu içinde oluşturulursa,
                 * using bloğundan çıkılır çıkılmaz GC(Garbage Collector)’ye devredilir
                 * ve hemen silinirler(Dispose edilirler).
                 * Çünkü IDisposable’den türemiş classlarda %100 Dispose metodu vardır.
                 * using bloğuda aslında blok sonunda bu metodu çalıştırmaktadır.
                 * Bu sayede manuel olarak nesneyi Dispose etmemize gerek kalmaz.*/
                using (TextWriter yazar = new StreamWriter(saveFileDialog1.FileName))
                {
                    myXMLSerializer.Serialize(yazar, DisariAktarilacaklar);
                }
                MessageBox.Show($"{DisariAktarilacaklar.Count} öğrenci XML dosyasıyla dışa aktarıldı.");
            }
        }

        private void XMLileIceAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Bilgisayarda olan XML dosyasını açmamıza yardımcı olacak bir DİYALOG nesnesine ihtiyaç var.
            KontrolleriTemizle();
            openFileDialog1.Title = "XML Dosyasını İçe Aktar";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                // Var olan dosyayı okuyabilmek için okuyucuya ihtiyacımız var.
                using (TextReader okuyucu = new StreamReader(openFileDialog1.FileName))
                {
                   ASinifiOgrencileri= (List<Ogrenci>)myXMLSerializer.Deserialize(okuyucu);
                    // 2. Yöntem: 
                    // ASinifiOgrencileri = myXMLSerializer.Deserialize(okuyucu) as List<Ogrenci>;
                    ListeleriDoldur();
                    MessageBox.Show($"{ASinifiOgrencileri.Count} öğrenci içeri aktarıldı.");
                }

            }

        }
    }
}
