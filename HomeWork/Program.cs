using System;
using System.Collections.Generic;
namespace HomeWork
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Client valeriy = new Client(1, "Zhimshenko Valeriy Albertovich", "wul.Shevchenka 23", "+380978753091", 32);
            Client oleg = new Client(1, "Zhimshenko Oleg Borisovich", "wul.Franka 12", "+380955211091", 23);
            List<RequestItem> items = new List<RequestItem>{ new RequestItem(new Article(2, "Iphone 7", 400, Article.Category.Gadgets), 3) };
            items.Add(new RequestItem(new Article(9, "Bread", 8, Article.Category.Products), 12));
            items.Add(new RequestItem(new Article(10, "Cooler", 8, Article.Category.Household), 1));
            Request req = new Request(221, valeriy,DateTime.Now,items);
            List<RequestItem> items2 = new List<RequestItem> { new RequestItem(new Article(90, "Iphone X", 500, Article.Category.Gadgets), 33) };
            items2.Add(new RequestItem(new Article(9, "Bread", 8, Article.Category.Products), 1));
            items2.Add(new RequestItem(new Article(10, "Cooler", 8, Article.Category.Household), 1));
            Request req2 = new Request(221, oleg,DateTime.Now,items2);
            Console.WriteLine(req);
            Console.WriteLine("Client Oleg:");
            Console.WriteLine(req2);
            /// <summary> 
            /// Сума замовлень клієнта збільшується, тим часом як кількість замовлень мешується на кількість замовлень в Request
            /// Дане завдання я бачив так
            /// </summary>
            Console.WriteLine("Press Any key to clear Console");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Articles sorting: ");
            Console.WriteLine("Before: ");
            List<Article> articles = new List<Article> { new Article(22, "Brot", 10, Article.Category.Products) };
            articles.Add(new Article(222, "Redmi Note 7", 200, Article.Category.Gadgets));
            articles.Add(new Article(321, "Seasoning", 3, Article.Category.Products));
            articles.Add(new Article(334, "Sausage", 33, Article.Category.Products));
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAfter sort by ICompareable: \n");
            articles.Sort();
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sort by lambda: ");
            articles.Sort((e, e2) => e.Price.CompareTo(e2.Price));
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sort by Method: \n");
            articles.Sort(Article.SortArticleByPrice);
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nComparer (sort) code by class with realization inteface IComparer (implicit)\n");
            ComparerArticleByCode nc = new ComparerArticleByCode();
            articles.Sort(nc.Compare);
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press Any key to clear Console\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
