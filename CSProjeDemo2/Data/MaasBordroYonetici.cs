using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSProjeDemo2.Data
{
    internal class MaasBordroYonetici:MaasBordro
    {
        // Text dosyasına yazılacak yöneticiye has özellikleri içerir.
        [JsonPropertyOrder(10)]
        public string BonusOrani { get; set; }

        [JsonPropertyOrder(11)]
        public string Bonus { get; set; }

        // Maaş bordro yönetici bilgilerini parametre verilen yönetici bilgileri ile doldurur.
        public void BordroIcerikGetir(Yonetici personel)
        {
            PersonelIsmi = personel.Name;
            CalismaSaati = personel.CalismaSaati.ToString();
            AnaOdeme = personel.Maas.ToString(CultureInfo.InvariantCulture);
            BonusOrani = personel.BonusOran.ToString(CultureInfo.InvariantCulture);
            Bonus = personel.Bonus.ToString(CultureInfo.InvariantCulture);
            ToplamOdeme = personel.ToplamOdenenTutarGetir().ToString(CultureInfo.InvariantCulture);
             
        }
    }
}
