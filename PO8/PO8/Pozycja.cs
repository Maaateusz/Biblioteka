using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO8
{
    abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja() { }
        public Pozycja(string t, string w, int rokW, int id)
        {
            this.tytul = t;
            this.id = id;
            this.wydawnictwo = w;
            this.rokWydania = rokW;
        }

        abstract public void WypiszInfo();
        public string PobierzTytul()
        {
            return tytul;
        }

        public int PobierzId()
        {
            return id;
        }
    }
}
