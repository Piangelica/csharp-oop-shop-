using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;
     

        public Prodotto(int codice)
        {
            this.codice = codice;
        }

        private Prodotto(int codice,string nome,string descrizione,double prezzo,double iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;

        }
        internal class Prodotto1
        {
            private int codice;
            private string nome;
            private string descrizione;
            private double prezzo;
            private double iva;
            private Prodotto1(int codice, string nome, string descrizione, double prezzo, double iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;

        }
            //Metodo
            public void CalcoloPrezzoBase(double prezzo)
            {
                double.Parse(Console.ReadLine());
            }
            //Metodo 
            public void CalcoloPrezzoIva()
            {
 double   CalcoloPrezzoIva = prezzo * 0.22;
                double.Parse(Console.ReadLine());
            
            }
        public void Stampa()

            {
                Console.WriteLine(CalcoloPrezzoIva);

            }
        }
    }
}