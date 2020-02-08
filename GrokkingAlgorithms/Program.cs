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
            //#region BinarySearch
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.Write("Имеется список: ");
            //foreach (int x in list) Console.Write(x+",");
            //Console.WriteLine();
            //Console.WriteLine("Введите, пожалуйста, число для поиска: ");
            
            //var userInput = int.Parse(Console.ReadLine());
            //ConsoleKey key = ConsoleKey.Enter;
            //while (key != ConsoleKey.Escape)
            //{
            //    bool result = new BinarySearch<int>().TryGetResult(list, userInput);
            //    Console.WriteLine("Результат работы бинарного поиска: " + result);
            //    if (result == true) Console.WriteLine("Элемент " + userInput + " был найден!");
            //    else Console.WriteLine("Элемент " + userInput + " не был найден!");

            //    Console.WriteLine("Для повтора операции нажмите любую клавишу, а для завершения работы программы \'Esc\'");
            //    key = Console.ReadKey().Key;
            //}
            //Console.WriteLine("Программа закончила выполнение.");
            //#endregion
            //#region BubbleSort
            //Console.WriteLine("Работа метода пузырьковой сортировки");
            //BubbleSort<int> bubbleSort = new BubbleSort<int>();
            //Console.WriteLine("Введите количество элементов в списке");
            //int userinput = int.Parse(Console.ReadLine());

            //Console.WriteLine("Элементы списка до сортировки: ");
            //var listBeforeBubbleSort = GetRandomList(userinput);

            //foreach (int x in listBeforeBubbleSort) Console.Write(x + ", ");
            //Console.WriteLine();

            //var listBubbleSort = bubbleSort.Sort(listBeforeBubbleSort);
            //Console.WriteLine("Элементы списка после сортировки: ");

            //foreach (int x in listBubbleSort) Console.Write(x+", ");
            //Console.WriteLine();
            //Console.WriteLine("Программа закончила выполнение");
            //#endregion
            //#region Factorial
            //Console.WriteLine("Вычисление факториала:");
            //Console.WriteLine("Введите число и нажмите 'Enter':");
            //int userinputfactorial = int.Parse(Console.ReadLine());
            //Console.WriteLine("Значение факториала: " + Factorial.GetResult(userinputfactorial));
            //Console.WriteLine("Программа закончила выполнение." +
            //    "");
            //#endregion
            #region QuickSort
            QuickSort quickSort = new QuickSort();
            var listQuickSort = GetRandomList(10);
            foreach (int i in listQuickSort) Console.Write(i+", ");
            Console.WriteLine();
            var resultQuickSort = quickSort.Sort(listQuickSort);
            foreach (int i in resultQuickSort) Console.Write(i + ", ");
            #endregion
            Console.ReadKey();
        }

        //Возвращает список заполненный случайными числами в диапазоне от "1" до "count"
        public static int[] GetRandomList(int count)
        {
            Random rand = new Random();
            int[] array = new int[count];
            for (int i = 0; i < count; i++) array[i] = rand.Next(1,count);
            return array;
        }
    }
}
