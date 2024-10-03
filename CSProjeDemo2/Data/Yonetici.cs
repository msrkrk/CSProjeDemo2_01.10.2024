using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.Write("\n");
            Console.WriteLine($"{Name} - {Title}");

            bool durum = true;
            durum = true;

            while (durum)
            {
                try
                {
                    Console.Write("\n");
                    Console.Write("Saatlik ücret giriniz: ");
                    int saatlikUcret = Convert.ToInt32(Console.ReadLine());

                    if (saatlikUcret < 500)
 
                    {
                        Console.WriteLine("Yöneticilere ait saatlik ücret 500'den küçük olamaz.");
                    }
                    else
                    {
                        _saatlikUcret = saatlikUcret;
                        durum = false;
                    }
                }
                catch (FormatException)
                {
                    durum = true;
                    Console.WriteLine("Geçerli bir saatlik ücret giriniz: ");
                }

                catch (Exception)
                {
                    durum = true;
                    Console.WriteLine("Bilinmeyen bir hata oluştu. Lütfen tekrar deneyin.");
                }
            }

            durum = true;

            while (durum)
            {
                try
                {
                    Console.Write("Aylık çalışma saatini giriniz: ");
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

                catch (Exception)
                {
                    durum = true;
                    Console.WriteLine("Bilinmeyen bir hata oluştu. Lütfen tekrar deneyin.");
                }
            }

            durum = true;

            while (durum)
            {
                try
                {
                    Console.Write("Bonus oranını giriniz(Ör:1.25): ");
                    double bonusOran = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (bonusOran <= 0)
                    {
                        Console.WriteLine("Bonus oranı 0'dan büyük olmalıdır.");
                    }
                    else
                    {
                        _bonusOran = bonusOran;
                        durum = false;
                    }
                }
                catch (FormatException)
                {
                    durum = true;
                    Console.WriteLine("Geçerli bir bonus oranı giriniz: ");
                }

                catch (Exception)
                {
                    durum = true;
                    Console.WriteLine("Bilinmeyen bir hata oluştu. Lütfen tekrar deneyin.");
                }
            }

            _maas = _saatlikUcret * _calismaSaati;

            _bonus = _maas * (decimal)_bonusOran;
            Console.Write("\n");
        }

        public override decimal ToplamOdenenTutarGetir()
        {
            return _maas + _bonus;  
        }


        //public override MaasBordro BordroIcerikGetir()
        //{
           

            //return "Maas Bordro, " + DateTime.Today.ToString("MMMM yyyy") + "\n" +

            //              "Personel Ismi:\t" + Name + "\n" +
            //              "Calisma Saati:\t" + CalismaSaati + "\n" +
            //              "Ana Odeme:\t" + Maas + "\n" +
            //              "Bonus Oranı:\t" + BonusOran + "\n" +
            //              "Bonus:\t\t" + Bonus + "\n" +
            //              "Toplam Odeme:\t" + ToplamOdenenTutarGetir() + "\n";

        //}


    }
  
}
