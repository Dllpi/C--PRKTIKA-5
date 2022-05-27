using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bird : Animal
    {
        public string fly;

        public delegate void Happening(string message);
        public event Happening Notify;

        public Bird(string fly, string Name, double Weight, string Class, string Description, string Sound) : base(Name, Weight, Class, Description, Sound)
        {
            this.fly = fly;
        }

        public override void Show()
        {
            Console.WriteLine($"Птица: \n летать: {fly}");
            if (fly == "no") Notify.Invoke($" Птица не может летать , она попала в ловушку охотников");
            base.Show();
        }

    }
}
