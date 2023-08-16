using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Используем цикл for так как есть четкие границы (до 97).\n");
            int increaseNumber = 7;
            int startNumber = 5;
            int endNumber = 100;

            for (int i = startNumber; i < endNumber; i+= increaseNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}
