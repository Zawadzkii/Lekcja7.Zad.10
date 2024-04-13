using System;

class Program
{
	static void Main(string[] args)
	{
		// Pobieranie długości boków od użytkownika
		Console.WriteLine("Podaj długości trzech boków trójkąta:");
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());

		// Sprawdzanie czy z podanych długości można zbudować trójkąt
		if (a + b > c && a + c > b && b + c > a)
		{
			Console.WriteLine("Można zbudować trójkąt");
		}
		else
		{
			Console.WriteLine("Nie można zbudować trójkąta");
		}
	}
}