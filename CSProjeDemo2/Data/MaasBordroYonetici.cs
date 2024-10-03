using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSProjeDemo2.Data
{
    internal class MaasBordroYonetici:MaasBordro
    {
        public string BonusOrani { get; set; }
        public string Bonus { get; set; }


        public void BordroIcerikGetir(Yonetici personel)
        {
            PersonelIsmi = personel.Name;
            CalismaSaati = personel.CalismaSaati.ToString();
            AnaOdeme = personel.Maas.ToString();
            BonusOrani = personel.BonusOran.ToString();
            Bonus = personel.Bonus.ToString().Replace(",",".");
            ToplamOdeme = personel.ToplamOdenenTutarGetir().ToString();
             
        }
    }
}
