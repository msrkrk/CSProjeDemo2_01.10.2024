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
        }

    }
}
