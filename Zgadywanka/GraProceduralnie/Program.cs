using System;
using System.Diagnostics;

namespace GraProceduralnie
{
    class Program
    {
        const string zaDuzo = "ZA DUZO";
        const string zaMało = "ZA Mało";
        const string trafiono = "Trafiono";
        static void Main(string[] args)
        {

            Console.WriteLine("Gra za Duzo za Malo");
            int a = WczytajLiczbe("Podaj dolny zakres losowania");
            int b = WczytajLiczbe("Podaj gorny zakres losowania");
            int wylosowana = Losuj(a, b);

#if DEBUG
            Console.WriteLine(wylosowana); // Howa kod po przeniesieniu sie  na tryb relise
#endif
            int licznik = 0;
            var stoper = new Stopwatch();  // mierzymy jak długo program dziala
            stoper.Start();                 //mierzymy jak długo program dziala
            while (true)
            {
                licznik++;
                int propozycja = WczytajLiczbe("Podaj swoją propozycje");
                string wynik = Ocena(wylosowana, propozycja);
                Console.WriteLine(wynik);
                if (wynik == trafiono)
                    break;
            }
            stoper.Stop();
            Console.WriteLine($"Liczba ruchów = {licznik}");
            Console.WriteLine($"czas Gry = {stoper.Elapsed}");
            Console.WriteLine("Koniec gry");
        }


        /// <summary>
        /// Losuje liczbe z podanego zakresu włącznie
        /// </summary>
        /// <param name="min">Dolne ograniczenie</param>
        /// <param name="max">Gorne ograniczenie</param>
        /// <returns></returns>
        static int Losuj(int min= 1, int max = 100)
        {
        
            var rnd = new Random();
            var min1 = Math.Min(min, max);
            var max1 = Math.Max(min, max);
            
                var los = rnd.Next(min1, max1 + 1);
           

            return los;
        }

        static int WczytajLiczbe(string prompt = "")
        {
            bool poprawnie = false;
            int wynik = 0; //zmienna lokalna musi byc zainicjowana (inicjujemy zmienna poza Try..catch )


            do
            {
                Console.WriteLine(prompt);
                var wczytano = Console.ReadLine();

                if (wczytano == "X" || wczytano == "x")
                {
                    Environment.Exit(0); // wychodzimy z aplikacji
                }

                try
                {
                    wynik = int.Parse(wczytano);
                    poprawnie = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Niepoprawny zapis liczby. Spróbuj jeszcze raz");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Przekroczony zakres");
                }
                catch (Exception)
                {
                    Console.WriteLine("Nieznany błąd");
                }

            } 
            while (!poprawnie);

            return wynik;

        }

        static string Ocena(int wyloowana, int propozycja)
        {
            if(wyloowana < propozycja)
            {
                return zaDuzo;
            }
            else if(wyloowana > propozycja)
            {
                return zaMało;
            }
            else
            {
                return trafiono;
            }
             
        }

    }
}
