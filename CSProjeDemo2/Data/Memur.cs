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
        public  override void MaasHesapla()
        {
            Console.WriteLine($"{Name} - {Title}");
            bool durum = true;
            while (durum)
            {
                try
                {
                    Console.Write("\n");
                    Console.Write("Memuriyet derecesini giriniz: ");
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
            Console.Write("\n");
        }



        //public override  MaasBordro BordroIcerikGetir()
        //{
           
            //return "Maas Bordro, " + DateTime.Today.ToString("MMMM yyyy") + "\n" +

            //          "Personel Ismi:\t" + Name + "\n" +
            //          "Calisma Saati:\t" + CalismaSaati + "\n" +
            //          "Ana Odeme:\t" + Maas + "\n" +
            //          "Mesai Ücreti:\t" + ekMesaiUcret + "\n" +
            //          "Toplam Odeme:\t" + ToplamOdenenTutarGetir() + "\n";
        //}

        public override  decimal ToplamOdenenTutarGetir()
        {
            return _maas + ekMesaiUcret;
        }
    }
}
