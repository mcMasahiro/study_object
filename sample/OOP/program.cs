using System.Collections.Generic;
using System;
namespace OOP
{
public class Program
{
    public static void Main()
    {
        Car myCar = new Car("myCar", 50);

        // 1回目の走行（燃料が不足するケース）
        myCar.Drive(60);
        // 燃料を外部から補充
        myCar.Refuel(20);

        // 2回目の走行
        myCar.Drive(60);

				//燃料を60減らす
				myCar.Fuel -= 60;

    }
}
}





		// public static void Main()
    // {
    //     List<Car> cars = new List<Car>
    //     {
    //         new Car(100),
    //         new EfficientCar(100),
    //         new InefficientCar(100)
    //     };

    //     int distance = 30;
    //     foreach (var car in cars)
    //     {
    //         car.Drive(distance); // ポリモーフィズムによって異なるDriveメソッドが呼ばれる
    //     }
    // }

