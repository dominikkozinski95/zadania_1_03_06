using System;
namespace Cwiczenia_3._06
{
	public class Zadanie7
	{
		public Zadanie7()
		{
            Console.WriteLine("Podaj współrzędne punktu P 'x' i 'y' oraz promień 'r' aby sprawdzić czy znajduje się w obrębie koła");

            Console.WriteLine("Podaj x");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj y");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj r");
            double r = double.Parse(Console.ReadLine());

            if(x * x + y * y <= r *r)
            {
                Console.WriteLine("Wpisane współrzędne znajdują się w obrębie koła");
            }
            else
            {
                Console.WriteLine("Wpisane współrzędne NIE znajdują się w obrębie koła");
            }

        }
    }
}

