﻿using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSProjeDemo2.Data
{
    
    public class DosyaOku
    {
        // Personeller.json dosyasındaki bilgilerin alındığı metoddur.
        public List<Personel> PersonelleriGetir()  
        {
   
            StreamReader okuyucu = new StreamReader("Personeller.json");

            string okunanMetin = okuyucu.ReadToEnd();

            okuyucu.Close();

            var getirilenNesne = JsonSerializer.Deserialize<List<Yonetici>>(
                okunanMetin,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            
            // Personeller.json dosysasındaki verileri Yonetici ve Memur Title'larına göre ayırır.
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
        }
    }

}
