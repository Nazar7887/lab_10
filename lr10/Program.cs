using System;

namespace lr10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть завдання:");
            Console.WriteLine("1 - Демонстрація роботи Stack");
            Console.WriteLine("2 - Демонстрація роботи Dictionary");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StackDemo stackDemo = new StackDemo();
                    stackDemo.Run();
                    break;
                case "2":
                    DictionaryDemo dictionaryDemo = new DictionaryDemo();
                    dictionaryDemo.Run();
                    break;
                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
            }

            Console.WriteLine("Роботу завершено.");
        }
    }
}
