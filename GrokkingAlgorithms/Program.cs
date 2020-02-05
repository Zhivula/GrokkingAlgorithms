using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 2,3,4,5,6,7,8,9};
            ConsoleKey key = ConsoleKey.Enter;
            while (key != ConsoleKey.Escape)
            {
                Console.WriteLine("Введите, пожалуйста, число: ");
                var userInput = int.Parse(Console.ReadLine());
                bool result = BinarySearch.TryGetResult(list, userInput);
                Console.WriteLine("Результат работы бинарного поиска: " + result);
                if (result == true) Console.WriteLine("Элемент " + userInput + " был найден!");
                else Console.WriteLine("Элемент " + userInput + " не был найден!");

                Console.WriteLine("Для повтора операции нажмите любую клавишу, а для завершения работы программы \'Esc\'");
                key = Console.ReadKey().Key;
            }
            Console.WriteLine("Программа закончила выполнение.");
            Console.ReadKey();
        }
    }
}
