using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Product
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public double cena { get; set; }
        public int ilosc { get; set; }

        public Product(int id, string nazwa, double cena, int ilosc)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.cena = cena;
            this.ilosc = ilosc;
        }
    }
}
