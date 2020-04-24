using System;
using System.Collections.Generic;
using System.Text;

namespace HouseWork_3_OOP
{
    class Motorcycle : Vehicle , Interface1
    {
        public Motorcycle(string name, int year, double price) : base(name, year, price)
        {
        }

        //МЕТОД ИЗ АБСТРАКТОНОГО КЛАССА
        public override void Display()
        {
            Console.WriteLine($"Название мотоцикла: {Name} \nГод выпуска: {YearOfIssue}; \nЦена: {Price} ");
        }

           
        //МЕТОД ИЗ ИНТЕРФЕЙСА
     public void StartTheEngine()
      {
            throw new NotImplementedException();
      }

    }
}
    
