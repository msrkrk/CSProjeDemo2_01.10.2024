// See https://aka.ms/new-console-template for more information
using CSProjeDemo2.Abstract;
using CSProjeDemo2.Data;


DosyaOku dosyaOku = new DosyaOku();
var personeller = dosyaOku.PersonelleriGetir();


MaasBordro maasBordro = new MaasBordro();


foreach (var person in personeller)
{
    person.MaasHesapla();

    maasBordro.BordroYaz(person);
}

maasBordro.OzetYaz(personeller);
