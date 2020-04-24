using System;
using System.Collections.Generic;
using System.Text;

namespace HouseWork_3_OOP
{
   class Car : Vehicle , Interface1
    {
        public int numbersOfDoors { get; set; }   // СВОЕ НОВОЕ ПОЛЕ - КОЛИЧЕСТВО ДВЕРЕЙ
        public Car(string name, int year, int numbersOfDoors, double price) : base(name, year, price) // Конструктор
        {
            this.numbersOfDoors = numbersOfDoors;
        }


        //МЕТОД ИЗ АБСТРАКТОНОГО КЛАССА
        public override void Display()
        {           
            Console.WriteLine($"Название автомобиля: {Name} \nГод выпуска: {YearOfIssue}; \nКоличество дверей : {numbersOfDoors}\nЦена: {Price} ");
        }


        public void StartTheEngine()  //МЕТОД ИЗ ИНТЕРФЕЙСА
        {        
            throw new NotImplementedException();
        }

        

    }



}

