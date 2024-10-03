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
    // Text dosyasına yazılacak memura has özellikleri içerir.
    internal class MaasBordroMemur:MaasBordro
    {
        [JsonPropertyOrder(10)]
        public string MesaiUcreti { get; set; }

        // Maaş bordro memur bilgilerini parametre verilen memur bilgileri ile doldurur.
        public void BordroIcerikGetir(Memur personel)
        { 
            PersonelIsmi = personel.Name;
            CalismaSaati = personel.CalismaSaati.ToString();
            AnaOdeme = personel.Maas.ToString(CultureInfo.InvariantCulture);
            MesaiUcreti = personel.ekMesaiUcret.ToString(CultureInfo.InvariantCulture);
            ToplamOdeme = personel.ToplamOdenenTutarGetir().ToString(CultureInfo.InvariantCulture);
        }
    }
}
