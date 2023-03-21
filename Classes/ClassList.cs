using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassList
{
    public class ArrayMaster
    {
        public static void CreateFromKeyboard()
        {
            Console.WriteLine("Hello, World!");

        }
        public static void PrintArray(string[] array) // вывод матрицы в консоль
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i],6} "); // форматирование строки
                Console.WriteLine();
            }
        }
    }


    public class ConsoleMaster
    {
        public static string PromtString(string message) // ввод с консоли
        {
            Console.Write(message);
            string? value = Console.ReadLine();
            return value;
        }
        public static int PromtInt(string message) // ввод с консоли
        {
            Console.Write(message);
            string value = (Console.ReadLine());
            int result = Convert.ToInt32(value);
            return result;
        }
    }
}
