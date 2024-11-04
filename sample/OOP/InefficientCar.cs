// using System;

// public class InefficientCar : Car
// {
//     public InefficientCar(string name, int initialFuel) : base(name, initialFuel) { }

 
//     public override void Drive(int distance)
//     {
//         int requiredFuel = distance * 2;
//         if (Fuel >= requiredFuel)
//         {
//             Fuel -= requiredFuel;
//             Console.WriteLine($"燃費の悪い車が{distance} km走行しました。残り燃料: {Fuel} L");
//         }
//         else
//         {
//             Console.WriteLine("燃料が不足しています。補充が必要です。");
//         }
//     }
// }