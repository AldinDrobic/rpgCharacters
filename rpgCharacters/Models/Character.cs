using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    abstract class Character
    {
        string name;
        int lvl;
        int basePrimaryAttributes;
        int totalPrimaryAttributes;

        #region Equip weapon
        /// <summary>
        /// Checks if weapon can be equiped by character
        /// </summary>
        /// <param name="weapon">This is an enum from the weapon object, could be eg. an axe</param>
        /// <param name="allowedWeapons">This list contains weapons allowed by a specific class</param>
        private void EquipWeapon(string weapon, List<string> allowedWeapons)
        {
            //Check if weapon is allowed by char class
            //Check if char lvl is high enough to equip weapon
        }
        #endregion

        #region Equip armor
        /// <summary>
        /// Checks if armor can be equiped by character
        /// </summary>
        /// <param name="armor">This is an enum from the armor object, could be eg. a plate</param>
        /// <param name="allowedArmors">This list contains armors allowed by a specific class</param>
        private void EquipArmor(string armor, List<string> allowedArmors)
        {
            //Check if armor is allowed by char class
            //Check if char lvl is high enough to equip armor
        }

        #endregion
    }
}
