using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSProjeDemo2.Data
{
    public class MaasBordro
    {
        public string PersonelIsmi { get; set; }

        public string CalismaSaati { get; set; }

        public string AnaOdeme { get; set; }

        public string ToplamOdeme { get; set; }


       

        // Personeli parametre alıyoruz niye statik yapamıyoruz?
        public void BodroYaz(Personel personel)
        {
            string path = personel.Name + ".txt";
            //StreamWriter okuyucu = new StreamWriter(path);
            string jsonData= $"Maas Bordro, {DateTime.Today.ToString("MMMM yyyy")}";
            if (personel.Title== "Yonetici")
            {
                MaasBordroYonetici maasBordro = new MaasBordroYonetici();
                maasBordro.BordroIcerikGetir((Yonetici)personel);
                jsonData += JsonSerializer.Serialize(maasBordro, new JsonSerializerOptions { WriteIndented = true });
            } 
            else if (personel.Title=="Memur")
            {
                MaasBordroMemur maasBordro = new MaasBordroMemur();
                 maasBordro.BordroIcerikGetir((Memur)personel);
                jsonData += JsonSerializer.Serialize(maasBordro, new JsonSerializerOptions { WriteIndented = true });
            }

           

            //okuyucu.Write(personel.BordroIcerikGetir());
            File.WriteAllText(path, jsonData);

            //okuyucu.Close();
        }

        public void OzetYaz(List<Personel> personeller)
        {
            Console.Write("\n");
            Console.Write("Personel");
            Console.Write("\t");
            Console.Write("Toplam Tutar");
            Console.Write("\n");

            foreach (Personel personel in personeller)
            {
                Console.Write(personel.Name);
                Console.Write("\t");
                Console.Write(personel.ToplamOdenenTutarGetir().ToString("N"));
                Console.Write("\t");
                if (personel.CalismaSaati < 150)
                {
                    Console.Write("150 SAATTEN AZ ÇALIŞMA!!!");
                }
                Console.Write("\n");
            }
        }

    }
}
