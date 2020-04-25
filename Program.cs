using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseWork_3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Шкода Октавиа", 2019, 4, 884000);
            car1.Display();
            Console.WriteLine();


            Motorcycle moto1 = new Motorcycle("Харлей Девидсон", 2018, 500000);
            moto1.Display();
            Console.WriteLine();


            Bike bike1 = new Bike("Стелс Пилот", 2020, 21, 20000);
            bike1.Display();

            
            //КОЛЛЕКЦИИ И СОРТИРОВКА
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\nКоллекции и сортировка");


            Car car01 = new Car("Шкода Октавиа", 2019, 4, 884000);
            Car car02 = new Car("Лада Веста", 2018, 4, 351000);
            Car car03 = new Car("Рено Меган Коуп", 2015, 3, 428000);
            Car ca0r4 = new Car("Мазда СX-5", 2015, 4, 670000);
            Car car05 = new Car("Опель Вектра", 2010, 4, 153000);

            List<Car> avto = new List<Car>();  //создаем список
            avto.Add(car01);
            avto.Add(car02);
            avto.Add(car03);
            avto.Add(ca0r4);
            avto.Add(car05);

            var s = avto.Where(z => z.numbersOfDoors == 4).Count();
            Console.WriteLine(s);


            Console.WriteLine("\nСортировка по цене\n");
            var sortprice1 = avto.OrderBy(z => z.Price);
            Console.WriteLine(string.Join("\n", sortprice1.Select(z => string.Format($"{z.Name,17} | {z.YearOfIssue,5} | {z.numbersOfDoors,2} | {z.Price,8} руб."))));
                       
                  
            Console.ReadLine();
        }
    }
}       
    

