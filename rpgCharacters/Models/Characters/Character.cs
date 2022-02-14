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
        private PrimaryAttributes BasePrimaryAttributes;
        private PrimaryAttributes TotalPrimaryAttributes;
        private Dictionary<ItemSlot, Item> Equipments;

        //public Character(string name, int strength, int dexterity, int intelligence, List<string> weaponsAllowed, List<string>armorsAllowed)
        //{
        //    this.Name = name;
        //    this.BasePrimaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);
        //    this.TotalPrimaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);
        //    this.WeaponsAllowed = weaponsAllowed;
        //    this.ArmorsAllowed = armorsAllowed;
        //}
        public Character(string name, int strength, int dexterity, int intelligence)
        {
            this.Name = name;
            this.BasePrimaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);
            this.TotalPrimaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);
        }

        #region Equip weapon
        /// <summary>
        /// Checks if weapon can be equiped by character
        /// </summary>
        /// <param name="weapon">This is an enum from the weapon object, could be eg. an axe</param>
        /// <param name="allowedWeapons">This list contains weapons allowed by a specific class</param>
        private void EquipWeapon(WeaponTypes weapon, List<string> allowedWeapons)
        {
            try
            {
                //Du måste ha objektet vapen här. Du måste skicka in ett helt vapen objekt till denna metod.
                if (weapon.ToString() == allowedWeapons[1])
                {
                    Console.WriteLine("You can equip this weapon");
                }
                
            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }

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
