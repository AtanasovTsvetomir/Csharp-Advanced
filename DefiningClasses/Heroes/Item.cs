using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        public int Strength { get; set; }

        public int Ability { get; set; }

        public int Intelligence { get; set; }

        public Item(int strength, int ability, int intelligence)
        {
            Strength = strength;
            Ability = ability;
            Intelligence = intelligence;
        }

        public override string ToString()
        {
            return 
                $"Item:" +
                Environment.NewLine +
                $"   * Strenght: {Strength}" +
                Environment.NewLine +
                $"  * Ability: {Ability}" +
                Environment.NewLine +
                $"  * Inteligence: {Intelligence}";
        }
    }
}
