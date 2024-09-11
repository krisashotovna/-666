
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            bool isCalculating = true;

            while (isCalculating)
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Введите операцию (+, -, *, /): ");
                char operation = char.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("Результат: " + result);
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine("Результат: " + result);
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка: неверная операция");
                        break;
                }

                Console.Write("Хотите продолжить вычисления? (да/нет): ");
                string continueInput = Console.ReadLine();

                if (continueInput.ToLower() == "нет")
                {
                    isCalculating = false;
                    Console.WriteLine("Программа завершена.");
                }
                else
                {
                    Console.WriteLine("Продолжаем вычисления...");
                }
            }
        }
    }
}
