using System;
using System.Collections.Generic;
using System.Text;

namespace lr10
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public string Producer { get; set; }
        public double Weight { get; set; }

        public Product(string name, double price, string unit, string producer, double weight)
        {
            Name = name;
            Price = price;
            Unit = unit;
            Producer = producer;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Name} - Ціна: {Price} грн/{Unit}, Виробник: {Producer}, Вага: {Weight} кг";
        }
    }
}
