using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("введите день недели");
                int x = int.Parse(Console.ReadLine());
                switch(x)
                {
                    case 1: Console.WriteLine("у нас сегодня 3 пары");
                        break;
                    case 2:
                        Console.WriteLine("у нас сегодня 4 пары");
                        break;
                    case 3:
                        Console.WriteLine("у нас сегодня 2 пары");
                        break;
                    case 4:
                        Console.WriteLine("у нас сегодня 4 пары");
                        break;
                    case 5:
                        Console.WriteLine("у нас сегодня 3 пары");
                        break;
                    case 6:
                        Console.WriteLine("у нас сегодня 3 пары");
                        break;
                    case 7:
                        Console.WriteLine("Сегодня выходной");
                        break;
                }
            }
        }
    }
}

