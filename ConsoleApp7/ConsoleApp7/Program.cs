using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача2.Необходимио создать обобщенный класс калькулятора с методом с одним параметрам, нам нужно в классе програм создать первый обьект у которого один параметр целым и второй целый, 
            // следующий объекте у первого целый второй вещественный
            // и третий обьект перый целый второй строковый.
            // Создаем первый объект с параметрами целыми числами
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine("Целочисленные значения:");
            Console.WriteLine("Сложение: " + intCalculator.Add(5, 3));
            Console.WriteLine("Вычитание: " + intCalculator.Subtract(5, 4));
            Console.WriteLine("Умножение: " + intCalculator.Multiply(6, 3));
            Console.WriteLine("Деление: " + intCalculator.Divide(4, 2));

            // Создаем второй объект с первым параметром целым и вторым вещественным числом
            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine("\nЦелое и вещественное значения:");
            Console.WriteLine("Сложение: " + doubleCalculator.Add(5, 3.5));
            Console.WriteLine("Вычитание: " + doubleCalculator.Subtract(5, 2.8));
            Console.WriteLine("Умножение: " + doubleCalculator.Multiply(3, 3.7));
            Console.WriteLine("Деление: " + doubleCalculator.Divide(2, 6.4));

            // Создаем третий объект с первым параметром целым и вторым строкой
            Calculator<string> stringCalculator = new Calculator<string>();
            Console.WriteLine("\nЦелое и строковое значения:");
            Console.WriteLine("Сложение: " + stringCalculator.Add("5", "3"));
            // Поддерживаем только сложение для строк
            Console.ReadKey();
            


        }
    }
}
