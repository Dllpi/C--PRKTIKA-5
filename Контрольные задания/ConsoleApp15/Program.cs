using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("yes", "Aslan", 250, "крупное млекопитающие", "Лев (лат. Panthera leo) — вид хищных млекопитающих, один из пяти представителей рода пантер (Panthera),\n \t   относящегося к подсемейству больших кошек (Pantherinae) в составе семейства кошачьих (Felidae).", "Meow , rrrrrrr");
            lion.Show();
            Console.WriteLine($"\nAslan: {lion.sound()}\n");


            Dolphin dolphin = new Dolphin("yes", "Flipper", 180, "Млекопитающие", "Дельфины — водные млекопитающие инфраотряда китообразных, принадлежащие либо к семейству\n \t   дельфиновых — морские, либо к нетаксономической группе речных дельфинов — пресноводные.\n \t   Любят воду и мелкую рыбу.", "Dolphin sound");
            dolphin.Show();
            Console.WriteLine($"\nFlipper: {dolphin.sound()}\n");

            Tit tit = new Tit("no", "Lastochka", 0.150, "Синицевые  — род птиц семейства синицевых. Обычный представитель \n \t   рода — большая синица широко распространена на территории России.", "taa taa");
            tit.Notify += DisplayMessange;
            tit.Show();
            
            Console.WriteLine($"\nLastochka: {tit.sound()}\n");
        }

        private static void DisplayMessange(string message)
        {
            Console.WriteLine(message);
        }
    }
}
