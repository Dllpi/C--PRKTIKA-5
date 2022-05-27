using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Lion : Animal
    {
        public string tsar;
        public Lion(string tsar, string Name, double Weight, string Class, string Description, string Sound) : base(Name, Weight, Class, Description, Sound)
        {
            this.tsar = tsar;
        }

        public override void Show()
        {
            Console.WriteLine($"Лев: \n царь животных: {tsar}");
            base.Show();
        }
    }
}
