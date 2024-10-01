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
        public override decimal MaasHesapla()
        {
            Console.WriteLine("Memur maas");

            return 0;
        }
    }
}
