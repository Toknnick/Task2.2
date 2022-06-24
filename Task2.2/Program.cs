using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = "";
            string stopWord = "exit";

            while (inputWord != stopWord)
            {
                Console.WriteLine("Введите стоп слово");
                inputWord = Console.ReadLine();
            }
        }
    }
}
