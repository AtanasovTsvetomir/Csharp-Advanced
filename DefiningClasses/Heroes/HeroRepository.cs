using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;

        public HeroRepository()
        {
            heroes = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            heroes.Add(hero);
        }

        public void Remove(string name)
        {
            if (heroes.Any(x => x.Name == name))
            {
                heroes.RemoveAll(x => x.Name == name);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            return heroes.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return heroes.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return heroes.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
        }

        public int Count
        {
            get { return heroes.Count; }
        }

        public override string ToString()
        {
            var AllHeroes = new StringBuilder();

            foreach (var hero in heroes)
            {
                AllHeroes.AppendLine($"{hero}");
            }

            return AllHeroes.ToString().TrimEnd();
        }
    }
}
