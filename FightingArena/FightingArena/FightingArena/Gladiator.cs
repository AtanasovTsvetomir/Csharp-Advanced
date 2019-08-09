using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FightingArena
{
    public class Gladiator
    {
        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public int GetTotalPower()
        {
            var result = (Stat.Strenght + Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills) +
                (Weapon.Sharpness + Weapon.Solidity + Weapon.Size);

            return result;
        }

        public int GetStatPower()
        {
            var result = Stat.Strenght + Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills;

            return result;
        }

        public int GetWeaponPower()
        {
            var result = Weapon.Sharpness + Weapon.Solidity + Weapon.Size;

            return result;
        }

        public override string ToString()
        {
            return $"[{Name}] - [{GetTotalPower()}]" +
                Environment.NewLine +
                $"  Weapon Power: [{GetWeaponPower()}]" +
                Environment.NewLine +
                $"  Stat Power: [{GetStatPower()}]";
        }
    }
}
