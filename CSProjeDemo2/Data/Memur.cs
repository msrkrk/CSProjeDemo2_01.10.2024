using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo2.Abstract;

namespace CSProjeDemo2.Data
{
    public class Memur : Personel
    {
        private int _memuriyetDerecesi;

        public int MemuriyetDerecesi
        {
            set
            {
                if (value == 1)
                {
                    _saatlikUcret = 500;
                }
                else if (value == 2)
                    _saatlikUcret = 600;
                else if (value == 3)
                    _saatlikUcret = 700;
                else if (value == 4)
                    _saatlikUcret = 800;
            }
        }

        public decimal ekMesaiUcret = 0;
        public override void MaasHesapla()
        {
            Console.WriteLine($"{Name} - {Title}");
            bool durum = true;
            while (durum)
            {
                try
                {
                    Console.WriteLine("Memuriyet derecesini giriniz: ");
                    int derece = Convert.ToInt32(Console.ReadLine());

                    if (derece != 1 && derece != 2 && derece != 3 && derece != 4)
                    {
                        Console.WriteLine("Memuriyet derecesi en az 1 en fazla 4 olmalıdır.");
                    }
                    else
                    {
                        MemuriyetDerecesi = derece;
                        durum = false;
                    }
                }
                catch (FormatException)
                {
                    durum = true;
                    Console.WriteLine("Sayı giriniz.Memuriyet derecesi en az 1 en fazla 4 olmalıdır.Tekrar giriniz: ");
                }
            }
            durum = true;

            while (durum)
            {
                try
                {
                    Console.WriteLine("Aylık çalışma saatini giriniz: ");
                    int calismaSaati = Convert.ToInt32(Console.ReadLine());

                    if (calismaSaati <= 0)
                    {
                        Console.WriteLine("Girdiğiniz çalışma saati geçerli değildir.");
                    }
                    else
                    {
                        _calismaSaati = calismaSaati;
                        durum = false;
                    }
                }
                catch (FormatException)
                {
                    durum = true;
                    Console.WriteLine("Geçerli bir çalışma saati giriniz: ");
                }
            }


            int ekMesaiSaati = _calismaSaati - 180;

            if (ekMesaiSaati <= 0)
            {
                ekMesaiUcret = 0;
            }
            else
            {
                ekMesaiUcret = ekMesaiSaati * (_saatlikUcret * 1.5m);
            }

            if (_calismaSaati > 180)
                _maas = 180 * _saatlikUcret;
            else
                _maas = _calismaSaati * _saatlikUcret;
        }



        public override string BordroIcerikGetir()
        {
                return "Maas Bordro, SUBAT 2020" + "\n" +
                    "Personel İsmi: " + Name + "\n" +
                    "Calisma Saati: " + CalismaSaati + "\n" +
                    "Ana Odeme: " + _maas + "\n" +
                    "Mesai Ücreti: " + ekMesaiUcret + "\n" +
                    "Toplam Odeme :" + ToplamOdenenTutarGetir() + "\n";
        }

        public override decimal ToplamOdenenTutarGetir()
        {
            return _maas + ekMesaiUcret;
        }
    }
}
