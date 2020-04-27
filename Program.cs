using System;
using System.Collections.Generic;
using System.Linq;
using NLog;


namespace HouseWork_3_OOP
{
    class Program
    {
        static Logger log = LogManager.GetCurrentClassLogger(); //ДОБАВЛЯЕМ АТРИБУТЫ 
        [MyAttribute(name = "Main", year = 2020)]
        static void Main(string[] args)          

        {
            //ДЗ №3 ООП---------------------------------------------------------------------

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("ООП\n");

            Car car1 = new Car("Шкода Октавиа", 2019, 4, 884000);
            car1.Display();
            Console.WriteLine();


            Motorcycle moto1 = new Motorcycle("Харлей Девидсон", 2018, 500000);
            moto1.Display();
            Console.WriteLine();
                       

            Bike bike1 = new Bike("Стелс Пилот", 2020, 21, 20000);
            bike1.Display();
                               
                     

            //ДЗ №4 КОЛЛЕКЦИИ И СОРТИРОВКА-------------------------------------------------------

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

           
            Console.WriteLine("\nСортировка по цене\n");
            var sortprice1 = avto.OrderBy(z => z.Price);
            Console.WriteLine(string.Join("\n", sortprice1.Select(z => string.Format($"{z.Name,17} | {z.YearOfIssue,5} | {z.numbersOfDoors,2} | {z.Price,8} руб."))));



            //ДЗ №5 ОБРАБОТКА ИСКЛЮЧЕНИЙ-----------------------------------------------------

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\nОбработка исключений\n");

            string a;
            int b;
            double c;

            Console.WriteLine("Введите марку и модель мотоцикла");
            a = Console.ReadLine();

            try
            {
                Console.WriteLine("Введите год выпуска");
                b = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Введите цену");
                c = Double.Parse(Console.ReadLine());
                Console.WriteLine("\nРезультат ввода:\n");
                Motorcycle moto2 = new Motorcycle(a, b, c);

                moto2.Display();
                Console.WriteLine();
                
            }
            catch (FormatException x)
            {
                log.Error ("Error! Неверный формат вводимых данных");
                Console.WriteLine($"\nНекорректно введенные данные. {x}");
                Console.ReadKey();               
            }
          
            Console.ReadLine();
        }
    }
}       
    

