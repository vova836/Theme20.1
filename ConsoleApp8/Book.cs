using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /// <summary>
    /// Создаем обобщенный класс Книга который будет описывать саму книгу
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Book<T>
    {
        /// <summary>
        /// Создаем поля Названия книги и Цены этой книги 
        /// </summary>
        string name;
        T price;

        /// <summary>
        /// Создаем свойства для поле Название книги 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Создаем свойства для поле Цена книги 
        /// </summary>
        public T Price { get; set; }

        /// <summary>
        /// Создаем Обьявления названия книги
        /// </summary>
        /// <param name="Name"></param>
        public void SetName(string Name)
        {
            name = Name;
        }

        /// <summary>
        /// Создаем Обьявления цены книги 
        /// </summary>
        /// <param name="Price"></param>
        public void SetPrice(T Price)
        {
            price = Price;
        }

        /// <summary>
        /// Создаем метод вывода информации о книги  
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Заголовок: {name}");
            Console.WriteLine($"Цена: {price}");
        }
    }
}
