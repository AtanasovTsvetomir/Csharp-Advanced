using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public string Name { get; set; }

        public Arena(string name)
        {
            Name = name;
            gladiators = new List<Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            if (gladiators.Any(x => x.Name == name))
            {
                gladiators.Remove(x => x.Name == name);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.OrderBy(x => x.GetStatPower()).LastOrDefault();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.OrderBy(x => x.GetWeaponPower()).LastOrDefault();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.OrderBy(x => x.GetTotalPower()).LastOrDefault();
        }

        public int Count
        {
            get { return gladiators.Count; }
        }

        public override string ToString()
        {
            return $"[{Name}] - [{gladiators.Count}] gladiators are participating.";
        }
    }
}
