﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    abstract class Item
    {
        protected long invNumber; // инвентарный номер – целое число
        protected bool taken; // хранит состояние объекта – имеется в библиотеке или нет, то есть взят на руки

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item()
        {
            this.taken = true;
        }

        public bool IsAvailable() // истина, если предмет имеется в библиотеке
        {
            if (taken == true) return true; else return false;
        }
        public long GetInvNumber() // инвентарный номер
        {
            return invNumber;
        }
        public void Take() // операция "взять"
        {
            taken = false;
        }
        abstract public void Return(); // операция "вернуть"

        public virtual void Show()
        {
            Console.WriteLine($"Состояние единицы хранения:\n Инвентарный номер: {invNumber}\n Наличие: {taken}");
        }

        public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }
    }
}
