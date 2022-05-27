using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Gamer
    {
        public delegate void Happening(string message);
        public event Happening Notify;

        string name;
        Dice seans;

        private int roll;

        public Gamer(string name)
        {
            this.name = name;
            seans = new Dice();
        }

        public int SeansGame()
        {
            roll = seans.Roll();

            if (roll == 6) MaximumPoints();

            return roll;
        }

        public override string ToString()
        {
            return name;
        }

        public void MaximumPoints()
        {
            Notify?.Invoke($"Бинго! 6 очков!");
        }

    }
}
