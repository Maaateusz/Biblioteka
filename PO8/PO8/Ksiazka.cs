using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO8
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        Autor autor;
        public Ksiazka() { }
        public Ksiazka(string t, string w, int rokW, int id,int liczbaStron, string imie, string nazwisko, string narodowosc)
        {
            this.tytul = t;
            this.id = id;
            this.wydawnictwo = w;
            this.rokWydania = rokW;
            this.liczbaStron = liczbaStron;
            autor = new Autor(imie, nazwisko, narodowosc);
        }
        public override void WypiszInfo()
        {
            Console.WriteLine(tytul +" "+ wydawnictwo +" "+ rokWydania +" ,Id: "+ id);
            Console.WriteLine("         " + liczbaStron +" stron, "+ autor.PobierzAutora());
        }
    }
}
