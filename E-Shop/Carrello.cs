using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop
{
    class Carrello
    {
        private int _id;
        string[] prodotto = new string[1000];
        private int counter;

        public Carrello(int id)
        {
            Id = id;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public void Aggiungi(Prodotto x)
        {
            x.Id = prodotto[counter];
            counter++;
        }

        public void Rimuovi(Prodotto x)
        {
            x.Id = prodotto[counter];
            counter--;
        }

        public int getProdotti()
        {
            return counter;
        }

        public void Svuota()
        {
            counter = 0;
        }
    }
}
