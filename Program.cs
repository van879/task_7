using System;

namespace task_7
{
	class Program
	{
		static void Main(string[] args)
		{
			int price = 7;
			int gold;
			int cristal;
			Console.WriteLine("введите количество золота (целое число)");
			gold = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"кристалов куплено - {gold / price}, золота осталось - {gold % price}");

		}
	}
}
