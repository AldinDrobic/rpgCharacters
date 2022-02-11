using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    public class Weapon : Item
    {
        private WeaponTypes WeaponType;
        private double Damage;
        private double AttackSpeed;
        public Weapon(string itemName, int itemLvl, Enum itemSlot, Enum weaponType) 
            :base(itemName, itemLvl, itemSlot)
        {
        }

       
    }
}
