using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Создаем обобщенный класс Калькулятор
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Calculator<T>
    {
        /// <summary>
        /// Создаем конструктор который принимает два параметра любого типа T и преобразует в динамический тип, а после прибавляет числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public T Add(T a, T b)
        {
            dynamic value1 = a;
            dynamic value2 = b;
            return value1 + value2;
        }
        /// <summary>
        /// Создаем конструктор который принимает два параметра любого типа T и преобразует в динамический тип, а после отнимаем числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public T Subtract(T a, T b)
        {
            dynamic value1 = a;
            dynamic value2 = b;
            return value1 - value2;
        }
        /// <summary>
        /// Создаем конструктор который принимает два параметра любого типа T и преобразует в динамический тип, а после умножаем числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public T Multiply(T a, T b)
        {
            dynamic value1 = a;
            dynamic value2 = b;
            return value1 * value2;
        }
        /// <summary>
        /// Создаем конструктор который принимает два параметра любого типа T и преобразует в динамический тип, а после разделяем числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public T Divide(T a, T b)
        {
            dynamic value1 = a;
            dynamic value2 = b;
            return value1 / value2;
        }
    }
}
