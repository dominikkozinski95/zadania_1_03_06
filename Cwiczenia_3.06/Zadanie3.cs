using System;
namespace Cwiczenia_3._06
{
	public class Zadanie3
	{
		public Zadanie3()
		{
            Console.WriteLine("OBLICZANIE BMI");

            Console.WriteLine("Podaj masę ciała");
            double masa = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wzrost");
            double wzrost = double.Parse(Console.ReadLine());

            double bmi = Math.Round(masa / (wzrost * wzrost), 2);

            Console.WriteLine("BMI wynosi: " + bmi);

        }
    }
}

