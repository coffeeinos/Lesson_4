using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the " + (i+1) + " number");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.WriteLine((i + 1) + " number is - " + array[i]);
            }

            Console.WriteLine("");

            //int sumOfEvenNumbers = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0)
            //    {
            //        sumOfEvenNumbers += array[i];
            //    }
            //}
            //Console.WriteLine("Sum of even numbers is - " + sumOfEvenNumbers);

            // Другой способ нахождения суммы четных чисел

            Console.WriteLine("Sum of even numbers is - " + array.Where(i => i % 2 == 0).Sum());

            Console.WriteLine("");

            // Метод Where выступает в данном случае как условие выборки, т.е. отыскать в массиве все четные числа (условие, которое записано 
            // в Where) и просуммировать их. Так же можно выборку сочитать и с другими действиями, например найти минимальное четное число

            //int smallestNumber = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < smallestNumber)
            //    {
            //        smallestNumber = array[i];
            //    }
            //}

            // Другой способ нахождения минимального элемента массива

            int smallestNumber = array.Min();

            Console.WriteLine("Smallest number is - " + smallestNumber);

            Console.WriteLine("");

            // Также можно найти и максимальный жлемент массива

            int greatestNumber = array.Max();

            Console.WriteLine("Greatest number is - " + greatestNumber);

            Console.WriteLine("");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine((i + 1) + " number is - " + array[i] + " from common array");
            }

            Console.WriteLine("");

            // Сортировка массива на уникальность вхождений

            int[] uniqueArray = array.Distinct().ToArray();

            for (int i = 0; i < uniqueArray.Length; i++)
            {
                Console.WriteLine((i + 1) + " number is - " + uniqueArray[i] + " from unique array");
            }

            Console.WriteLine("");

            // Сортировка массива на возростание

            int[] increasingArray = array.OrderBy(i => i).ToArray();

            for (int i = 0; i < increasingArray.Length; i++)
            {
                Console.WriteLine((i + 1) + " number is - " + increasingArray[i] + " from increasing array");
            }

            Console.WriteLine("");

            // Сортировка массива на убывание

            int[] decreasingArray = array.OrderByDescending(i => i).ToArray();

            for (int i = 0; i < increasingArray.Length; i++)
            {
                Console.WriteLine((i + 1) + " number is - " + decreasingArray[i] + " from decreasing array");
            }

            Console.WriteLine("");

            // Сортировка массива по возрастанию без создания дополнительного массива

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine((i + 1) + " number is - " + array[i] + " from sorted common array");
            }

            Console.WriteLine("");

            // Сортировка массива в обратном порядке без создания дополнительного массива

            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine((i + 1) + " number is - " + array[i] + " from revers common array");
            }

            Console.WriteLine("");

            // Сортировка массива по вхождению элемента

            int firstOddNumber = Array.Find(array, i => i % 2 != 0);

            Console.WriteLine("First odd number is - " + firstOddNumber);

            Console.WriteLine("");

            //Метод Find ищет первый элемент в массиве, который будет удовлетворять заданному условию

            int LastOddNumber = Array.FindLast(array, i => i % 2 != 0);

            Console.WriteLine("Last odd number is - " + LastOddNumber);

            Console.WriteLine("");

            //Метод FindLast ищет последний элемент в массиве, который будет удовлетворять заданному условию

            int[] allOddNumber = Array.FindAll(array, i => i % 2 != 0);

            for (int i = 0; i < allOddNumber.Length; i++)
            {
                Console.WriteLine((i + 1) + " number is - " + allOddNumber[i] + " from odd array");
            }

            Console.WriteLine("");

            //Метод FindAll ищет все элементы в массиве, которые будут удовлетворять заданному условию

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Number " + array[i] + " has index - " + Array.FindIndex(array, j => j == array[i]));
            }

            Console.WriteLine("");

            // Метод FindIndex ищет индекс первого элемента в массиве, которые будут удовлетворять заданному условию

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Number " + array[i] + " has index - " + Array.FindLastIndex(array, j => j == array[i]));
            }

            Console.WriteLine("");

            // Метод FindLastIndex ищет индекс последнего элемента в массиве, которые будут удовлетворять заданному условию
        }
    }
}
