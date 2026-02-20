using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20022026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            for (int i = 0; i < 100; i++) 
            { 
                if (i % 3 != 0) {  c++; }
            }
            Console.WriteLine(c);
            Console.WriteLine("Задание 1: ");
            number1();
            Console.WriteLine("Задание 2: ");
            number2();
            Console.WriteLine("Задание 3: ");
            number3();
            Console.WriteLine("Задание 4: ");
            number4();
            Console.WriteLine("Задание 5: ");
            number5();
            Console.WriteLine("Задание 6: ");
            number6();
        }
        public static void number1()
        {
            Console.WriteLine("Нечетные числа: ");
            for (int i = 11; i < 20; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void number2()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество чисел, кратных 3: " + count);
        }
        public static void number3()
        {
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Число в квадрате: " + Math.Pow(number, 2));
        }
        public static void number4() 
        {
            int number = 2;
            while (number <= 1000) {
                Console.Write(number + " ");
                number *= 2;
            }
            Console.WriteLine();
        }
        public static void number5()
        {
            int password = 19841202;
            Console.WriteLine("Введите пароль: ");
            int inputPassword = int.Parse(Console.ReadLine());
            while(inputPassword != password)
            {
                Console.WriteLine("Неверный пароль");
                Console.WriteLine("Введите пароль снова: ");
                inputPassword = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Верный пароль");
        }
        public static void number6()
        {
            Console.WriteLine("Введите число: ");
            int inputNumber = int.Parse(Console.ReadLine());
            while (inputNumber > 0)
            {
                if (inputNumber >= 10 && inputNumber <= 99)
                {
                    int units = inputNumber % 10;
                    int dozens = inputNumber / 10;
                    int unitsSquare = units * units;
                    int dozensSquare = dozens * dozens;
                    int sumSquare = unitsSquare + dozensSquare;
                    Console.WriteLine("Сумма квадратов: " + sumSquare);
                }
                else if (inputNumber >= 100 && inputNumber <= 999)
                {
                    int units = inputNumber % 10;
                    int dozens = inputNumber / 10 % 10;
                    int hundreds = inputNumber / 100;
                    int unitsSquare = units * units;
                    int dozensSquare = dozens * dozens;
                    int hundredsSquare = hundreds * hundreds;
                    int sumSquare = unitsSquare + dozensSquare + hundredsSquare;
                    Console.WriteLine("Сумма квадратов: " + sumSquare);
                }
            }
        }   
    }
}