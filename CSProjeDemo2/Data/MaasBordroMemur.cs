using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSProjeDemo2.Data
{
    internal class MaasBordroMemur:MaasBordro
    {
        public string MesaiUcreti { get; set; }

        public void BordroIcerikGetir(Memur personel)
        {
             
            PersonelIsmi = personel.Name;
            CalismaSaati = CalismaSaati;
            AnaOdeme = personel.Maas.ToString();
            MesaiUcreti = personel.ekMesaiUcret.ToString();
            ToplamOdeme = personel.ToplamOdenenTutarGetir().ToString();

        }
    }
}
