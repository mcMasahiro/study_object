using System;

public class Program
{
    public static void Main()
    {
        int fuel = 50;
        int distance = 60;

        // Drive関数を呼び出し
        fuel = Drive(fuel, distance);

        // 燃料が足りない場合は補充して再度Drive関数を呼び出し
        if (fuel < distance)
        {
            fuel = Refuel(fuel, 20);
            fuel = Drive(fuel, distance);
        }
    }
    // Drive関数

    public static int Drive(int fuel, int distance)
    {
        if (fuel >= distance)
        {
            fuel -= distance;
            Console.WriteLine($"車が{distance} km走行しました。残り燃料: {fuel} L");
            return fuel;
        }
        else
        {
            Console.WriteLine("燃料が不足しています。補充してください。");
            return fuel;
        }
    }

    // Refuel関数
    public static int Refuel(int fuel, int amount)
    {
        fuel += amount;
        Console.WriteLine($"燃料を{amount} L補充しました。現在の燃料量: {fuel} L");
        return fuel;
    }


}
