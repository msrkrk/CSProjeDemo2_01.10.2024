using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo2.Abstract;

namespace CSProjeDemo2.Data
{
    public class Yonetici : Personel
    {
        // Aşağıdaki özelliklerin setterları yok çünkü set özelliğini bu sınıf içeresinde encapsule ediyoruz. Dışardan set yasak!

        private double _bonusOran;

        public double BonusOran
        {
            get { return _bonusOran; }
        }


        private decimal _bonus;

        public decimal Bonus
        {
            get { return _bonus; }
        }


        public override void MaasHesapla()
        {
            Console.WriteLine($"{Name} - {Title}");

            Console.Write("Saatlik ücreti giriniz: ");
            _saatlikUcret = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Aylık çalışma saatini giriniz: ");
            _calismaSaati = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bonus oranını giriniz: ");
            _bonusOran = Convert.ToDouble(Console.ReadLine());

            _maas = _saatlikUcret * _calismaSaati;

            _bonus = _maas * (decimal)_bonusOran;

           
        }

        public override string BordroIcerikGetir()
        {
            return "Maas Bordro, SUBAT 2020" + "\n" +

                          "Personel Ismi: " + Name + "\n" +
                          "Calisma Saati:" + CalismaSaati + "\n" +
                          "Ana Odeme:" + Maas + "\n" +
                          "Bonus Oranı: " + BonusOran + "\n" +
                          "Bonus " + Bonus + "\n" +
                          "Toplam Odeme " + (Maas + Bonus) + "\n";

        }


    }
  
}
