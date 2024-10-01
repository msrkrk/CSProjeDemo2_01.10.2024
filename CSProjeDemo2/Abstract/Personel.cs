using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Abstract
{
    public abstract class Personel
    {
        public string Name { get; set; }

        public string Title { get; set; }

        protected decimal _saatlikUcret;

        public decimal SaatlikUcret
        {
            get { return _saatlikUcret; }
        }


        protected int _calismaSaati;

        public int CalismaSaati
        {
            get { return _calismaSaati; }
        }


        protected decimal _maas;

        public decimal Maas
        {
            get { return _maas; }
        }

        public abstract void MaasHesapla();

        public abstract string BordroIcerikGetir();

        public abstract decimal ToplamOdenenTutarGetir();
    }
}
