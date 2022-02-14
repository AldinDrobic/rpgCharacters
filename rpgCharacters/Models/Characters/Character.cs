using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    public abstract class Character
    {
        private string Name;
        private int Lvl = 1;
        private PrimaryAttributes PrimaryAttributes;
        private double TotalAttributes;
        private Dictionary<ItemSlot, Item> Equipments;

        public Character(string name, int strength, int dexterity, int intelligence)
        {
            this.Name = name;
            this.PrimaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);
        }

        #region Getters
        /// <summary>
        /// Get character name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return Name;
        }
        /// <summary>
        /// Get character lvl
        /// </summary>
        /// <returns></returns>
        public int getLvl()
        {
            return Lvl;
        }
        /// <summary>
        /// Get primary attributes
        /// </summary>
        /// <returns></returns>
        public PrimaryAttributes GetPrimaryAttributes()
        {
            return PrimaryAttributes;
        }
        /// <summary>
        /// Get total attributes
        /// </summary>
        /// <returns></returns>
        public double getTotalAttributes()
        {
            return TotalAttributes;
        }
        #endregion


        #region Equip weapon
        /// <summary>
        /// Checks if weapon can be equiped by character
        /// </summary>
        /// <param name="weapon">This is an enum from the weapon object, could be eg. an axe</param>
        /// <param name="allowedWeapons">This list contains weapons allowed by a specific class</param>
        //public abstract void EquipWeapon(Weapon weapon);

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
