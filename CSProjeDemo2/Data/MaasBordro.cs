using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Data
{
    public class MaasBordro
    {
        // Personeli parametre alıyoruz niye statik yapamıyoruz?
        public void BodroYaz(Personel personel)
        {
            StreamWriter okuyucu = new StreamWriter(personel.Name + ".txt");

            okuyucu.Write(personel.BordroIcerikGetir());

            okuyucu.Close();
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
