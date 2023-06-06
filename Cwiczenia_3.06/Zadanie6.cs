using System;
namespace Cwiczenia_3._06
{
	public class Zadanie6
	{
		public Zadanie6()
		{
            Console.WriteLine("Podaj boki trójąta aby sprawdzić czy może być trójkątem równobocznym");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == b && a == c)
            {
                Console.WriteLine("Trójkąt jest równoboczny");
            }
            else
            {
                Console.WriteLine("Trójkąt nie jest równobocznym");
            }
        }
	}
}

