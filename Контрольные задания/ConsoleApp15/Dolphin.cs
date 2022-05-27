using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dolphin : Animal
    {
        public string swim;
        public Dolphin(string swim, string Name, double Weight, string Class, string Description, string Sound) : base(Name, Weight, Class, Description, Sound)
        {
            this.swim = swim;
        }

        public override void Show()
        {
        Console.WriteLine($"Дельфин: \n плавать: {swim}");
        base.Show();
        }
    }
}
