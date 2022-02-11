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
        /// <summary>
        /// Constructor to instantiate a object.
        /// </summary>
        /// <param name="itemName">Name of the item eg. "Axe"</param>
        /// <param name="itemLvl">Required level to use item</param>
        /// <param name="itemSlot">In which slot is item equipped, eg "Slot.Weapon"</param>
        /// <param name="weaponTypes">What type of weapon, eg. "Axe"</param>
        public Weapon(string itemName, int itemLvl, ItemSlot itemSlot, WeaponTypes weaponTypes) 
            :base(itemName, itemLvl, itemSlot)
        {
        }

        /// <summary>
        /// Returns weapon type
        /// </summary>
        /// <returns></returns>
        public WeaponTypes getWeaponType()
        {
            return this.WeaponType;
        }
        /// <summary>
        /// Calculates weapons damage and then returns damage.
        /// </summary>
        /// <returns></returns>
        public double getDPS()
        {
            return this.Damage * this.AttackSpeed;
        }
       
    }
}
