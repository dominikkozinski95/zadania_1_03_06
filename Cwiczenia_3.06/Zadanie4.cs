using System;
namespace Cwiczenia_3._06
{
	public class Zadanie4
	{
		public Zadanie4()
		{
            Console.WriteLine("Podaj 4 liczby całkowite");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if(b == 0 || d == 0)
            {
                Console.WriteLine("Brak rozwiązania");
            }
            else
            {
                int x = a / b;
                int y = c / d;

                Console.WriteLine("Licznik wynosi : " + x);
                Console.WriteLine("Mianownik wynosi : " + y);
            }
        }
    }
}

