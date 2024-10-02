using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSProjeDemo2.Data
{
    // DosyaOku sınıfından ihtiyacım olan yerde bir örnek yaratmak yerine static tek örneği kullanmak için static yaptım.
    public class DosyaOku
    {
        public List<Personel> PersonelleriGetir()
        {
            // ==> Deserialization
            StreamReader okuyucu = new StreamReader("Personeller.json");

            string okunanMetin = okuyucu.ReadToEnd();

            okuyucu.Close();

            var getirilenNesne = JsonSerializer.Deserialize<List<Kisi>>(
                okunanMetin,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            

            List<Personel> personeller = new List<Personel>();

            foreach (var kisi in getirilenNesne)
            {
                if (kisi.Title == "Yonetici")
                {
                    var yonetici = new Yonetici();
                    yonetici.Name = kisi.Name;
                    yonetici.Title = kisi.Title;

                    personeller.Add(yonetici);
                }

                if (kisi.Title == "Memur")
                {
                    var memur = new Memur();
                    memur.Name = kisi.Name;
                    memur.Title = kisi.Title;

                    personeller.Add(memur);
                }


            }

            return personeller!;
            ////abc
            ///fgdfdfgdf

        }
    }

    public class Kisi
    {





        public string Name { get; set; }


        public string Title { get; set; }
    }
}
