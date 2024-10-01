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
        public override string BordroIcerikGetir()
        {
            throw new NotImplementedException();
        }

        public override string CalismaSaati150denAzOlanlar()
        {
            throw new NotImplementedException();
        }

        public override void MaasHesapla()
        {
            Console.WriteLine("Memur maas");

        }
    }
}
