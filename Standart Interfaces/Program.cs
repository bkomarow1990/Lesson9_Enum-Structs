using System;
using System.Collections.Generic;
namespace Standart_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil ivan = new Pupil("Ivan",12,3,5,6,7,12,11,10);
            Pupil ivan2 = (Pupil)ivan.Clone();
            ivan2.ChangeMark(0, 12);
            Console.WriteLine(ivan);
            // Clone correct
            List<Pupil> pupils = new List<Pupil>
            {
                ivan,
                new Pupil("Anton",17 )
            };
            Console.WriteLine();
            foreach (var item in pupils)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            pupils.Sort();
            foreach (var item in pupils)
            {
                Console.WriteLine(item);
            }
        }
    }
}
