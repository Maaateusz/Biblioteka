using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO8
{
    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;
        List<Pozycja> listaPozycji;

        public Katalog() { }
        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
            listaPozycji = new List<Pozycja>();
        }

        public void DodajPozycje(Pozycja asd)
        {
            listaPozycji.Add(asd);
        }
        public void WyszukajPoTytule(string tytul)
        {
            throw new NotImplementedException();
        }

        public void WyszukajPoId(int id)
        {
            //listaPozycji.Find(Pozycja.id == id);
            Console.WriteLine();
        }

        public void WypiszWszystko()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("         Dzial: " + dzialTematyczny);
            Console.WriteLine();
            foreach(Pozycja a in listaPozycji)
            {
                a.WypiszInfo();
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
