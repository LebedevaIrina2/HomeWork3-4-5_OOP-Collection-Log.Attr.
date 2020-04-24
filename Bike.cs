using System;
using System.Collections.Generic;
using System.Text;

namespace HouseWork_3_OOP
{
    class Bike : Vehicle
    {
        // СВОЕ НОВОЕ ПОЛЕ -количество скоростей у велосипеда
        public int Speed { get; set; }

        public Bike(string name, int year, int speed, double price) : base (name, year, price) //конструктор
        {
            this.Speed = speed;
        }

        //МЕТОД ИЗ АБСТРАКТОНОГО КЛАССА
        public override void Display()
        {
            Console.WriteLine($"Название велосипеда: {Name} \nГод выпуска: {YearOfIssue}; \nКоличество скоростей: {Speed}\nЦена: {Price}");
        }

       



    }
}
