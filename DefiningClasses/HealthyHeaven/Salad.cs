using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HealthyHeaven
{
    public class Salad
    {
        List<Vegetable> products;

        public string Name { get; set; }

        public Salad(string name)
        {
            Name = name;

            products = new List<Vegetable>();
        }

        public int GetTotalCalories()
        {
            return products.Sum(x => x.Calories);
        }

        public int GetProductCount()
        {
            return products.Count;
        }

        public void Add(Vegetable product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"* Salad {Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            foreach (var product in products)
            {
                result.AppendLine($"{product}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
