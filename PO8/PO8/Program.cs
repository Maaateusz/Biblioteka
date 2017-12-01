using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO8
{
    class Program
    {
        static void Main(string[] args)
        {
            Ksiazka ks1 = new Ksiazka("W pustyni i w puszczy", "Insignis", 1934, 1, 323, "Henryk", "Sienkiewicz", "Poland");
            Ksiazka ks2 = new Ksiazka("AIsjkdn aklsj","Mieajsda", 1994, 2, 33, "Adam", "Asdklsda", "Poland");
            Ksiazka ks3 = new Ksiazka("sfdgsdfgsdfg", "Insignis", 1999, 3, 1323, "Henryko", "Joaososoa", "Russia");

            Czasopismo cz1 = new Czasopismo("Czasopisemko", "Nieznane", 2012, 4, 1);
            Czasopismo cz2 = new Czasopismo("AsdaSDAS", "Znane", 2017, 5, 2);
            Czasopismo cz3 = new Czasopismo("Kanalizcja", "Nieznane", 2012, 6, 3);

            Katalog Przygodowe = new Katalog("Przygodowe");
            Katalog Techniczne = new Katalog("Techniczne");

            Przygodowe.DodajPozycje(ks1);
            Przygodowe.DodajPozycje(ks2);
            Przygodowe.DodajPozycje(ks3);

            Techniczne.DodajPozycje(cz2);
            Techniczne.DodajPozycje(cz3);

            Przygodowe.WypiszWszystko();
            Console.WriteLine();
            Techniczne.WypiszWszystko();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
