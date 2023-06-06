using System;
namespace Cwiczenia_3._06
{
	public class Zadanie5
	{
		public Zadanie5()
		{
            Console.WriteLine("Podaj dwie cyfry, program wypisze większą");

            double pierwsza = double.Parse(Console.ReadLine());
            double druga = double.Parse(Console.ReadLine());

            double wynik = Math.Max(pierwsza,druga);
            Console.WriteLine("Wyższa cyfra to: " + wynik);
        }
    }
}

