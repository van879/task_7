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
			int remainsOfGold;

			Console.WriteLine("введите количество золота (целое число)");
			gold = Convert.ToInt32(Console.ReadLine());
			cristals = gold / priceOfCristal;
			remainsOfGold = gold % priceOfCristal;

			Console.WriteLine($"кристалов куплено - {cristals}, золота осталось - {remainsOfGold}");
		}
	}
}
