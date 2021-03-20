using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Clsswork
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Drink("Pepsi", Drink.DrinkTypes.Carbonated,"Pepsiko",2290,12));
            list.Add(new Drink("Sprite", Drink.DrinkTypes.Carbonated,"Pepsiko",2100,12));
            list.Add(new Drink("Fanta", Drink.DrinkTypes.Carbonated,"Pepsiko",2305,13));
            list.Add(new Drink("Tea", Drink.DrinkTypes.HotDrink,"Myself :)",200,8));
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Template Sort: ");
            Console.WriteLine();
            List<Drink> list2 = new List<Drink>();
            list2.Add(new Drink("Pepsi", Drink.DrinkTypes.Carbonated, "Pepsiko", 2290, 12));
            list2.Add(new Drink("Sprite", Drink.DrinkTypes.Carbonated, "Pepsiko", 2100, 12));
            list2.Add(new Drink("Fanta", Drink.DrinkTypes.Carbonated, "Pepsiko", 2305, 13));
            list2.Add(new Drink("Tea", Drink.DrinkTypes.HotDrink, "Myself :)", 200, 8));
            list2.Sort();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
