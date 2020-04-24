using System;

namespace HouseWork_3_OOP
{
     class Program
    {
         static void Main(string[] args)
        {
          Car car1 = new Car ("Шкода Октавиа", 2019, 4, 800000);
          car1.Display();
          Console.WriteLine();


            Motorcycle moto1 = new Motorcycle ("Харлей Девидсон", 2018, 500000);
          moto1.Display();
          Console.WriteLine();


            Bike bike1 = new Bike("Стелс Пилот", 2020, 21, 20000);
            bike1.Display();


          Console.ReadLine();
        }
        
    } 
}
