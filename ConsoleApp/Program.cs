// See https://aka.ms/new-console-template for more information
using CSProjeDemo2.Data;


var personeller = DosyaOku.PersonelleriGetir();

foreach (var person in personeller)
{
    person.MaasHesapla();
}

Console.WriteLine(personeller.Count);