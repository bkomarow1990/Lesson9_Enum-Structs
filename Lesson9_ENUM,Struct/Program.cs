using System;

namespace Lesson9_ENUM_Struct
{
    class Program
    {
        enum Color : byte { Red = 1, Green, Blue, Orange};
        static void Main(string[] args)
        {

            Color color = Color.Green;
            Console.WriteLine(color);
            if (Enum.TryParse<Color>(Console.ReadLine(), out color))
            {
                Console.WriteLine($"OK: {color}");
                if (Enum.IsDefined(typeof(Color),color))
                {
                    Console.WriteLine($"{color} is exist in enum Colors");
                }
                else
                {
                    Console.WriteLine("Isn`t exist");
                }
            }
            else {
                Console.WriteLine("Incorrect enum value");
            }
            string[] namesColor = Enum.GetNames(typeof(Color));
            for (int i = 0; i < namesColor.Length; i++)
            {
                Console.WriteLine($"\t\t{namesColor[i]}");
            }
            var colors = Enum.GetValues(typeof(Color));
            foreach (Color c in colors)
            {
                Console.WriteLine($"{c} --- {(byte)(c)}");
            }
            Console.WriteLine("Task 1");
            ConsoleColor[] namesColor2 = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            foreach (var c in namesColor2)
            {
                Console.WriteLine($"Color : {c.ToString()}");
                Console.BackgroundColor = c;
                
                if (Console.ForegroundColor == Console.BackgroundColor)
                {
                    try { 
                    Console.ForegroundColor = c;
                    }
                    catch  (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = c - 2;
                    }
                }

                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }
        
    }
}
