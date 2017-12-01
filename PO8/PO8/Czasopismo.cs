using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO8
{
    class Czasopismo : Pozycja
    {
        private int numer;
        public Czasopismo() { }
        public Czasopismo(string t, string w, int rokW, int id,int numer)
        {
            this.tytul = t;
            this.id = id;
            this.wydawnictwo = w;
            this.rokWydania = rokW;
            this.numer = numer;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(tytul + " " + wydawnictwo + " " + rokWydania + " ,Id: " + id + " ,numer: " + numer);
        }
    }
}
