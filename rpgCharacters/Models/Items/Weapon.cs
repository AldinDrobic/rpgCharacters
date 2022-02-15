using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpgCharacters.Models.Attributes;

namespace rpgCharacters.Models
{
    public class Weapon : Item
    {
        private WeaponTypes _weaponType;
        private WeaponAttributes _weaponAttributes;
        /// <summary>
        /// Constructor to instantiate a object.
        /// </summary>
        /// <param name="itemName">Name of the item eg. "Axe"</param>
        /// <param name="itemLvl">Required level to use item</param>
        /// <param name="itemSlot">In which slot is item equipped, eg "Slot.Weapon"</param>
        /// <param name="weaponTypes">What type of weapon, eg. "Axe"</param>
        public Weapon(string itemName, int itemLvl, ItemSlot itemSlot, WeaponTypes weaponTypes, WeaponAttributes weaponAttributes) 
            :base(itemName, itemLvl, itemSlot)
        {
            this._weaponType = weaponTypes;
            this._weaponAttributes = weaponAttributes;
        }

        #region Return a weapon type
        /// <summary>
        /// Returns weapon type
        /// </summary>
        /// <returns></returns>
        public WeaponTypes GetWeaponType()
        {
            return this._weaponType;
        }
        #endregion

        #region Calculate DPS
        /// <summary>
        /// Calculates weapons damage and then returns damage.
        /// </summary>
        /// <returns></returns>
        public double GetDPS()
        {
            return this._weaponAttributes.Damage * this._weaponAttributes.AttackSpeed;
        }
        #endregion



    }
}
