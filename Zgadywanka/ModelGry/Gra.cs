using System;
using System.Collections.Generic;

namespace ModelGry
{
    public class Gra
    {
        //DANE
        private readonly int wylosowana; //jezeli pole jest readonly. mozna przypisac tylko raz
        public StanGry Stan{get; private set;}

        public List<Ruch> HistoriaGry { get; }


        //METODY (KONSTUKTORY)
        public Gra(int a =1 , int b =10)
        {
            Random rnd = new Random();
           wylosowana = rnd.Next(a, b + 1);
            Stan = StanGry.Trwa;
            HistoriaGry = new List<Ruch>(); //Inicjuje wszystie pola przed rozpoczeciem gry



        }

        public int Wylosowana
        {
            get
            {
                if( Stan == StanGry.Zakonczona)
                {
                    return wylosowana;
                }
                else
                {
                    throw new NotSupportedException("W trakcie gry nie dostaniesz tej informacji");
                }
                
            }
        }

        public Odp Odpowiedz(int propozycja)
        {
            
            if (propozycja < wylosowana)
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.ZaMalo));
                return Odp.ZaMalo;

            }
            else if (propozycja > wylosowana )
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.ZaDuzo));
                return Odp.ZaDuzo;
            }
                
            else
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.Trafiono));
                Stan = StanGry.Zakonczona;
                return Odp.Trafiono;
            }
            
        }

        public void Poddaj()
        {
            Stan = StanGry.Zakonczona;
        }


    }

    public enum StanGry
    {
        Rozpoczeta,
        Trwa,
        Zapalzowana,
        Zakonczona,
    }

    public enum Odp
    {
        ZaMalo = -1,
        Trafiono = 0,
        ZaDuzo = 1

    }
}
