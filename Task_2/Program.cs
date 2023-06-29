using System;

namespace Task_2
{
    class Program
    {
        static int FoundNumber2(int number)
        {
            int digits = ((int)Math.Log10((double)number) + 1);
            
            if (digits < 3) 
            { 
                Console.WriteLine("Ошибка! Введите трёхзначное число");
                return -1;
            }
            else
            {
                int step1 = (number % 100);
                int step2 = (step1 / 10);
                return step2;
            }
        }

        static int FoundNumber3(int number)
        {
            int digits = ((int)Math.Log10((double)number) + 1);
            
            if (digits < 3) 
            { 
                Console.WriteLine("Третьей цифры нет");
                return -1;
            }
            else
            {
                int rest = number % 100;
                int step2 = rest % 10;
                return step2;
            }
        }
        
        static string CheckHoliday(int day)
        {
            if (day < 1 || day > 7)
            {
                return "Введите число от 1 до 7";
            }
            switch (day)
            {
                case 6: return "Да, это выходной"; break;
                case 7: return "Да, это выходной"; break;
                default: return "Нет, это рабочий день"; break;               
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("**************** Задача №1 ****************");
            Console.WriteLine("Введите трёхзначное число для задачи 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Второе число: {FoundNumber2(number1)}");
            Console.WriteLine("**************** Задача №2 ****************");
            Console.WriteLine("Введите трёхзначное число для задачи 2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Тетье число: {FoundNumber3(number2)}");
            Console.WriteLine("**************** Задача №3 ****************");
            Console.WriteLine("Введите число дня недели для задачи 3");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Выходной? {CheckHoliday(number3)}");
        }
    }
}
