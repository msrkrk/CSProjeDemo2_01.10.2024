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
    internal class MaasBordroMemur:MaasBordro
    {

        [JsonPropertyOrder(10)]
        public string MesaiUcreti { get; set; }

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
