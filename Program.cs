using System;

namespace task_7
{
	class Program
	{
		static void Main(string[] args)
		{
			int priceOfCristal = 7;
			int gold;
			int cristals;
			int desiredCristals;

			Console.WriteLine("введите количество золота (целое число)");
			gold = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("сколько кристалов хотите купить (целое число)");
			cristals = Convert.ToInt32(Console.ReadLine());
			gold -= cristals * priceOfCristal;
			

			Console.WriteLine($"кристалов куплено - {cristals}, золота осталось - {gold}");
		}
	}
}
