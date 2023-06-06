using System;
namespace Cwiczenia_3._06
{
	public class Zadanie8
	{
		public Zadanie8()
		{

            Console.WriteLine("Prosty kalkulator czterech działań");
            Console.WriteLine("Dostępne operacje:");
            Console.WriteLine("1 - Dodawanie");
            Console.WriteLine("2 - Odejmowanie");
            Console.WriteLine("3 - Mnożenie");
            Console.WriteLine("4 - Dzielenie");

            Console.Write("Podaj pierwszą liczbę: ");
            double liczba1 = double.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            double liczba2 = double.Parse(Console.ReadLine());

            Console.Write("Wybierz numer działania: ");
            int numerDzialania = int.Parse(Console.ReadLine());

            double wynik = 0;

            switch (numerDzialania)
            {
                case 1:
                    wynik = liczba1 + liczba2;
                    break;
                case 2:
                    wynik = liczba1 - liczba2;
                    break;
                case 3:
                    wynik = liczba1 * liczba2;
                    break;
                case 4:
                    if (liczba2 != 0)
                    {
                        wynik = liczba1 / liczba2;
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez zero!");
                        wynik = liczba1 / 0;
                    }
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy numer działania!");
                    break;
            }

            Console.WriteLine("Wynik: " + wynik);
            






    }
}
}

