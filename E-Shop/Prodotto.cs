using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop
{
    class Prodotto
    {
        private string _nome;
        private string _marca;
        private int _id;
        private float _prezzo;

        public Prodotto(string nome, string marca, int id, float prezzo)
        {
            Nome = nome;
            Marca = marca;
            Id = id;
            Prezzo = prezzo;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
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

        public float Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                _prezzo = value;
            }
        }
    }
}
