using System;
using System.Collections.Generic;
using System.Text;

namespace lr10
{
    class DictionaryDemo
    {
        public void Run()
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            products.Add(1, new Product("Молоко", 20.5, "л", "Молокозавод", 1));
            products.Add(2, new Product("Хліб", 15.0, "шт", "Хлібозавод", 0.5));
            products.Add(3, new Product("Цукор", 30.0, "кг", "Фермер", 1));

            Console.WriteLine("\nЕлементи в Dictionary:");
            foreach (var pair in products)
            {
                Console.WriteLine($"Ключ: {pair.Key}, Значення: {pair.Value}");
            }

            Console.Write("\nВведіть ключ для пошуку: ");
            if (int.TryParse(Console.ReadLine(), out int key) && products.TryGetValue(key, out Product product))
            {
                Console.WriteLine($"Знайдено: {product}");
            }
            else
            {
                Console.WriteLine("Елемент не знайдено.");
            }

            Console.Write("\nВведіть ключ для видалення: ");
            if (int.TryParse(Console.ReadLine(), out key) && products.Remove(key))
            {
                Console.WriteLine("Елемент видалено.");
            }
            else
            {
                Console.WriteLine("Елемент не знайдено для видалення.");
            }

            Console.WriteLine($"Кількість елементів у Dictionary: {products.Count}");

            products.Clear();
            Console.WriteLine("Dictionary очищено.");
        }
    }
}
