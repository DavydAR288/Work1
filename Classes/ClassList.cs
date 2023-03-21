using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassList
{
    public class ArrayMaster
    {
        /// <summary>
        /// Создание строчного массива
        /// </summary>
        /// <param name="elements">получаемая длина массива</param>
        /// <returns></returns>
        public static string[] CreateFromKeyboard(int length)
        {
            Console.WriteLine($"Создание строчного массива с кличеством элементов {length}");
            string[] matrix = new string[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите слово №{i+1}: ");
                string? inputWord=Console.ReadLine();
                if (inputWord != "") matrix[i] = inputWord;
                else i--;
            }
            return matrix;
        }
        public static string[] CreateNewArray(string[] array, int length)
        {
            int count = 0;
            int countNew = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i].Length <= 3) count++;
            }
            
            string[] arrayNew = new string[count];
            for (int i = 0; i < length; i++)
            {
                if (array[i].Length <= 3)
                {
                    arrayNew[countNew] = array[i];
                    countNew++;
                }
            }
            return arrayNew;
        }

        /// <summary>
        /// Вывод в консоль строчного массива
        /// </summary>
        /// <param name="array">Строчный массив для вывода</param>
        public static void PrintArray(string[] array, string textOutput) 
        {
            Console.Write($"{textOutput}");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i]}");
                if (i != array.GetLength(0)-1) Console.Write($", ");
                else Console.Write($".");
            }
            Console.WriteLine();
        }
    }
}
