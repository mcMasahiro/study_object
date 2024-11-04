using System;

/// <summary>
/// 車のクラス.燃料の1Lにつき1Km走れる．
/// </summary>
public class Car
{
    public string Name{get; private set;}
    public int Fuel; //Todo

    public Car(string name, int initialFuel)
    {
        Name = name;
        Fuel = initialFuel;
        Console.WriteLine($"{Name}を作成しました。初期燃料: {Fuel} L");
    }

    public void Drive(int distance) //Todo
    {
        if (Fuel >= distance)
        {
            Fuel -= distance;
            Console.WriteLine($"{Name}が{distance} km走行しました。残り燃料: {Fuel} L");
        }
        else
        {
            Console.WriteLine("燃料が不足しています。補充が必要です。");
        }
    }

    public void Refuel(int amount)
    {
        Fuel += amount;
        Console.WriteLine($"燃料を{amount} L補充しました。現在の燃料量: {Fuel} L");
    }
}








// public class EfficientCar : Car
// {
//     public EfficientCar(string name, int initialFuel) : base(name, initialFuel) { }

//     public override void Drive(int distance)
//     {
//         int fuelNeeded = distance / 2; // 燃料消費量を半分に設定
//         if (Fuel >= fuelNeeded)
//         {
//             Fuel -= fuelNeeded;
//             Console.WriteLine($"燃費の良い車が{distance} km走行しました。残り燃料: {Fuel} L");
//         }
//         else
//         {
//             Console.WriteLine("燃料が不足しています。補充が必要です。");
//         }
//     }
// }

// public class InefficientCar : Car
// {
//     public InefficientCar(string name, int initialFuel) : base(name, initialFuel) { }

//     public override void Drive(int distance)
//     {
//         int fuelNeeded = distance * 2; // 燃料消費量を2倍に設定
//         if (Fuel >= fuelNeeded)
//         {
//             Fuel -= fuelNeeded;
//             Console.WriteLine($"燃費の悪い車が{distance} km走行しました。残り燃料: {Fuel} L");
//         }
//         else
//         {
//             Console.WriteLine("燃料が不足しています。補充が必要です。");
//         }
//     }
// }