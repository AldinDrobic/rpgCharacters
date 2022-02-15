using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Attributes
{
    public class WeaponAttributes
    {
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }

        public WeaponAttributes(double damage, double attackSpeed)
        {
            this.Damage = damage;
            this.AttackSpeed = attackSpeed;
        }
    }
}
