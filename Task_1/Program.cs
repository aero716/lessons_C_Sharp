using System;
using System.Linq;


namespace Lesson1_CS
{
    class Program
    {
        static public int FoundMaxNumber(int[] numbers)
        {
            /*
             * Задача #2 и #4:
             * Определение максимального числа из 2-х b 3-х чисел
             */
            int maxNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if(maxNumber <= numbers[i])
                {
                    maxNumber = numbers[i];
                }
            }
            return maxNumber;
        }
        

        static public string CheckEvenNumber(int number)
        {
            /* Задача #6:
             * Проверка чётности числа
            */
            if (number % 2 == 0)
            {
                return "чётное";
            }
            else
            {
                return "НЕчётное";
            }
        }


        static int[] FoundEvenNumbers(int number)
        {
            /* Задача #8:
             * Поиск чётных чисел с 1 до number
            */
            int[] arrEvenNumbers = new int[100];
            int j = 0;
            for (int i = 2; i <= number; i = i + 2)
            {
                arrEvenNumbers[j] = i;
                j++;
            }
            arrEvenNumbers = arrEvenNumbers.Where(val => val != 0).ToArray();
            return arrEvenNumbers;
        }


        static void Main(string[] args)
        {
            int[,] couplesNumbers = new int[3, 2] { {5, 7}, {2, 10}, {-9, -3} };                    // Задача №2           
            int[,] triplesNumbers = new int[3, 3] { { 2, 3, 7 }, { 44, 5, 78 }, { 22, 3, 9 } };     // Задача №4
            int[] Numbers = new int[3] { 4, -3, 7 };                                                // Задача №6
            int number = 11;                                                                        // Задача №8

            // Задача №2
            for (int i = 0; i < couplesNumbers.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine("Maximum number from numbers " + couplesNumbers[i, 0] + ", " + couplesNumbers[i, 1] + ": " + FoundMaxNumber(new int[] { couplesNumbers[i, 0], couplesNumbers[i, 1] }));
            }
            // Задача №4
            for (int i = 0; i < triplesNumbers.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine("Maximum number from numbers " + triplesNumbers[i, 0] + ", " + triplesNumbers[i, 1] + ", " + triplesNumbers[i, 2] + ": " + FoundMaxNumber(new int[] { triplesNumbers[i, 0], triplesNumbers[i, 1], triplesNumbers[i, 2] }));
            }
            // Задача №6
            for (int i = 0; i < Numbers.Length; i++) 
            {
                Console.WriteLine("Число " + Numbers[i] + " " + CheckEvenNumber(Numbers[i]));
            }
            // Задача №8
            int[] arr = FoundEvenNumbers(number);
            string myString = "Для числа " + number + " составляющие чётные числа: ";
            for (int i = 0; i < arr.Length; i++)
            {
                myString += Convert.ToString(arr[i]) + " ";
            }
            Console.WriteLine(myString);
        }
    }
}