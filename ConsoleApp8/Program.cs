using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задача1.Создать обобщенный класс который описывает книгу в классе должны быть внутренние поля названия книги,
            ///цены кинги и название книги кроме этого должны быть сойства для этих полей 
            ///и метод который задает названия книги и метод с универсальным параметром который задает цену о книге 
            ///и метод который задает информацию о книге, 
            ///в основном классе создать обькекты обобщенного класса которых цена книги целого типа а во втором строке тип строковой.
            Book<int> book1 = new Book<int>();
            book1.SetName("Книга 1");
            book1.SetPrice(25);
            book1.DisplayInfo();

            Book<string> book2 = new Book<string>();
            book2.SetName("Книга 2");
            book2.SetPrice("$15");
            book2.DisplayInfo();

            ///Необходимио создать обобщенный класс калькулятора с методом с двумя параметрами нам нужно в классе програм создать первый обьект у которого один параметр целым и второй целый, 
            ///следующий объекте у первого целый второй вещественный 
            ///и третий обьект перый целый второй строковый.

            //Person tom = new Person(546, "Tom");
            //Person bob = new Person("abc123", "Bob");
            //int tomId = (int)tom.Id;
            //string bobId = (string)bob.Id;
            //Console.WriteLine(tomId);   //546
            //Console.WriteLine(bobId);   //abc123

            //Person<int> tom = new Person<int>(546, "Tom");  // упаковка не нужна
            //Person<string> bob = new Person<string>("abc123", "Bob");

            //int tomId = tom.Id;      // распаковка не нужна
            //string bobId = bob.Id;  // преобразование типов не нужно

            //Console.WriteLine(tomId);   // 546
            //Console.WriteLine(bobId);   // abc123
            Console.ReadKey();
        }
    }
}
