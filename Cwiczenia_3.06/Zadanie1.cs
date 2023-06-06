using System;
namespace Cwiczenia_3._06
{
	public class Zadanie1
	{
		public Zadanie1()
		{
            Console.WriteLine("Podaj 3 liczby aby wyliczyć średnią arytmetyczną");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double avg = Math.Round((a + b + c)/3,2);

            Console.WriteLine("Średnia wynos: " + avg);
        }
    }
}

