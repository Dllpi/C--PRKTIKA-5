using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Animal
    {
/*        public delegate void Happening(string message);
        public event Happening Notify;

        private Random random;*/

        protected string Sound;

        protected string Description;
        protected string Name;
        protected string Class;
        protected double Weight;

        public Animal(string Name, double Weight, string Class, string Description, string Sound)
        {
            this.Description = Description;
            this.Name = Name;
            this.Class = Class;
            this.Weight = Weight;
            this.Sound = Sound;
        }

        public virtual void Show()
        {
            Console.WriteLine($" Имя: {Name}\n Класс: {Class}\n Вес: {Weight}кг\n Описание: {Description}");
        }

        public string sound() => Sound;

    }
}
