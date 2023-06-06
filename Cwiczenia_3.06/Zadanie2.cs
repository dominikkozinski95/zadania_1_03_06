using System;
namespace Cwiczenia_3._06
{
	public class Zadanie2
	{
		public Zadanie2()
		{
            Console.WriteLine("Podaj pole koła aby obliczyć obwód");

            double pole = double.Parse(Console.ReadLine());

            double promien = Math.Sqrt(pole / Math.PI);

            double obwod = 2 * Math.PI * promien;

            Console.WriteLine("Obwód wynosi " + obwod);
        }
    }
}

