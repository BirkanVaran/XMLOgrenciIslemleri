using System;
using System.Collections.Generic;
using System.Text;

namespace _4._3._3
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTarihi { get; set; }
        public string Sinif { get; set; }
        private byte _yas = 0;
        public byte Yas
        {

            get
            {

                _yas = Convert.ToByte(DateTime.Now.Year - DTarihi.Year);
                return _yas;
            }

        }

        // ToString() metodunu ezelim.
        public override string ToString()
        {
            return this.Ad + " " + this.Soyad.ToUpper() + " - " + Yas + " yaşında. " + this.AldigiSecmeliDersler.Count + " adet seçmeli dersi var.";
        }

        public bool SecmeliDersAliyorMu { get; set; }
        public List<string> AldigiSecmeliDersler { get; set; } = new List<string>();
    }
}
