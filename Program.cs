using System;

namespace brejk
{
    class Program
    {
        static void Main(string[] args)
        {

            menu();


           /* //Console.WriteLine("Hello World!");
            double mnoznik;
            double mnoznik1;
            double suma;
            
            mnoznik = double.Parse(Console.ReadLine());
            mnoznik1 = double.Parse(Console.ReadLine());
            suma = mnoznik*mnoznik1;
            Console.WriteLine($"suma wynosi: {suma}");


            */
        }
        static void menu()
        {

            Console.WriteLine("Kalkulator");
            Console.WriteLine("Wpisz '1' aby uzyc dodwania ");
            Console.WriteLine("Wpisz '2' aby uzyc odejmowanie ");
            Console.WriteLine("Wpisz '3' aby uzyc mnozenia ");
            Console.WriteLine("Wpisz '4' aby uzyc dzielenia ");
            Console.WriteLine("Wpisz '5' aby uzyc reszty z dzielenia (modulo)");
            int wybor = int.Parse(Console.ReadLine());
            double suma;

            double liczba1 = 0, liczba2 = 0;
            Console.Write("Podaj pierwsza liczbe: ");
            liczba1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj druga liczbe: ");
            liczba2 = double.Parse(Console.ReadLine());

            if (wybor == 1)
            {
                suma = liczba1 + liczba2;
                Console.WriteLine($"Suma dodwania wynosi: {suma}");
            }
            else if(wybor == 2)
            {
                suma = liczba1 - liczba2;
                Console.WriteLine("Suma odejmowania wynosi: " + suma);
            }
            else if(wybor == 3)
            {
                suma = liczba1 * liczba2;
                Console.WriteLine($"Suma mnozenia wynosi: {suma}"); 
            }
            else if(wybor == 4)
            {
                suma = liczba1 / liczba2;
                Console.WriteLine($"Suma dzielenia wynosi: {suma}");
            }
            else if (wybor == 5)
            {
                suma = liczba1 % liczba2;
                Console.WriteLine($"Suma wynosi: {suma}");
            }






        }

    }

}


