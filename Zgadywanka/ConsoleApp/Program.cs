using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za Duzo za Malo");

            //1. Komputer losuje
            #region losowanie
            var los = new Random(); // Tworze obiekt tupu random
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); // Howa kod po przeniesieniu sie  na tryb relise
#endif
            Console.WriteLine("Wylosowałem liczbę od 1 - 100. \nOdgadnij ją!");
            #endregion


            bool odgadniete = false;



            // Dopuki nie odgadniete
            while(!odgadniete)
            {
                //2. człowiek proponuje 
                

                Console.Write("Podaj swoją propozycje");

                //int propozycja = int.Parse(Console.ReadLine());

                int propozycja = int.Parse(Console.ReadLine());


                //3. komp ocenia



                    if (propozycja < wylosowana)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Za mało!");
                        Console.ResetColor();
                    }
                    else if (propozycja > wylosowana)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Za duzo!");
                        Console.ResetColor();


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Trafiono!");
                        Console.ResetColor();
                        odgadniete = true;

                    }

                   // Console.Write("Podaj swoją propozycje jeszcze raz");

                   // propozycja = int.Parse(Console.ReadLine());


               // }

               // Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("Trafiono!");
                //Console.ResetColor();

            }

            Console.WriteLine("Koniec Gry. Wygrałes!");

        }
    }
}
