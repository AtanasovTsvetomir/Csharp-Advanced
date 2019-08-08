using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HealthyHeaven
{
    public class Restaurant
    {
        List<Salad> salads;

        public string Name { get; set; }

        public Restaurant(string name)
        {
            Name = name;

            salads = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            salads.Add(salad);
        }

        public bool Buy(string name)
        {
            if (salads.Any(x => x.Name == name))
            {
                salads.RemoveAll(x => x.Name == name);

                return true;
            }

            return false;
        }

        public Salad GetHealthiestSalad()
        {
            return salads.OrderBy(x => x.GetTotalCalories()).FirstOrDefault();
        }

        public string GenerateMenu()
        {
            var result = new StringBuilder();

            result.AppendLine($"{Name} have {salads.Count} salads:");

            foreach (var salad in salads)
            {
                result.AppendLine($"{salad}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
