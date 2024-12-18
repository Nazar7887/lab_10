using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lr10
{
    class StackDemo
    {
        public void Run()
        {
            Stack stack = new Stack();

            stack.Push("Текст");
            stack.Push(100);
            stack.Push(99.99);

            Console.WriteLine("Елементи в Stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nВидаляємо: {stack.Pop()}");

            Console.WriteLine($"Верхній елемент: {stack.Peek()}");

            Console.WriteLine($"Кількість елементів: {stack.Count}");

            stack.Clear();
            Console.WriteLine("Stack очищено.");
        }
    }
}
