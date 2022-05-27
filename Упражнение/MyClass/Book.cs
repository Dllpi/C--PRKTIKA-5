using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Book : Item
    {
        public delegate void ProcessBookDelegate(Book book);
        public static event ProcessBookDelegate RetSrok;

        private String author; // автор
        private String title; // название
        private String publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания
/*        private bool returnSrok;*/

        private static double price = 9;

        private bool returnSrok = false;

        public bool ReturnSrok
        {
            get
            {
                return returnSrok;
            }
            set
            {
                returnSrok = value;
                if (ReturnSrok) RetSrok(this);
            }
        }

        public override string ToString()
        {
            return this.title + ", " + this.author + " Инв. номер " + this.invNumber;
        }

        /*public bool ReturnSrok { get; set; }*/

        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            if (ReturnSrok) processBook(this);
        }

        public void SetBook(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book(String author, String title, String publisher, int pages, int year,long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override void Show()
        {
            Console.WriteLine($"\nКнига:\n Автор: {author}\n Название: {title}\n Год издания: {year}\n Издательство: {publisher}\n {pages}стр.\n Стоимость аренды: {Book.price}");
            base.Show();
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
/*
        public void ReturnSrok()
        {
            returnSrok = true;
        }*/

        public override void Return() // операция "вернуть"
        {
            if (ReturnSrok == true) taken = true;
            else taken = false;
        }
    }
}
