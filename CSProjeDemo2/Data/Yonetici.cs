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

        private decimal _saatlikUcret;

        public decimal SaatlikUcret
        {
            get { return _saatlikUcret; }
            set
            {
                if (value < 500)
                {
                    throw new ArgumentException ("Yöneticilere ait saatlik ücret 500 TL'nin altında olamaz. Lütfen saatlik ücreti tekrar giriniz.");
                }

                else
                    _saatlikUcret = value;
            }
        }


        private int _calismaSaati;

        public int CalismaSaati
        {
            get { return _calismaSaati; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException("Çalışma saati 0 saatden küçük olamaz!");
                }
                _calismaSaati = value;
            }
        }

        private decimal _maas;

        public decimal Maas
        {
            get { return _maas; }
            set { _maas = value; }
        }


        private double _bonusOran;

        public double BonusOran
        {
            get { return _bonusOran; }
            set { _bonusOran = value; }
        }


        private decimal _bonus;

        public decimal Bonus
        {
            get { return _maas * (decimal)_bonusOran;}
            set { _bonus = value; }
        }


        public override decimal MaasHesapla()
        {
            Console.WriteLine("Yonetıcı maas");
            Console.WriteLine("Çalışma saati: "
            return 0;
        }
    }
}
