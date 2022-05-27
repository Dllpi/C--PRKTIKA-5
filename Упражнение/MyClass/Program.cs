using System;

namespace MyClass
{
	class Program
	{
		static void Main(string[] args)
		{
/*            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
			Book.SetPrice(12);
			b2.Show();

			Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
			mag1.Show();

			Console.WriteLine("\nТестирование полиморфизма");
			
			Item it;
			it = b2;
			it.TakeItem();
			it.Return();
			it.Show();
			it = mag1;
			it.TakeItem();
			it.Return();
			it.Show();*/

			Book b4 = new Book("Толстой Л.Н.", "Анна Каренина", "Знание", 1204, 2014, 103, true);
			Book b5 = new Book("Неш Т", "Программирование для профессионалов", "Вильямс", 1200, 2014, 108, true);

			Book.RetSrok += new
			Book.ProcessBookDelegate(Operation.MetodObrabotchik);

			b4.ReturnSrok = true;
			b5.ReturnSrok = true;

			Console.WriteLine("\nКниги возвращены в срок:");
			b4.ProcessPaperbackBooks(Operation.PrintTitle);
			b5.ProcessPaperbackBooks(Operation.PrintTitle);
		}
	}
}
