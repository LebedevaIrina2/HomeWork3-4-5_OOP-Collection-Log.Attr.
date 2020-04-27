using System;
using System.Collections.Generic;
using System.Text;

namespace HouseWork_3_OOP
{    
    abstract class Vehicle
    {
        public string Name { get; set; } // Марка транспортного средства
        public int YearOfIssue { get; set; } // Год выпуска
        public double Price { get; set; } // цена        

        public Vehicle(string name, int year, double price)
        {
            Name = name;
            YearOfIssue = year;
            Price = price;
        }

        public abstract void Display();      // Метод - вывод информации на экран



    }

    
}
