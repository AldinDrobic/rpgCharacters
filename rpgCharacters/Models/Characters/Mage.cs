using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Characters
{
    public class Mage: Character
    {

        private List<ArmorType> ArmorsAllowed = new List<ArmorType>();
        private List<WeaponTypes> WeaponsAllowed = new List<WeaponTypes>();
        public Mage(string name, int strength, int dexterity, int intelligence)
            :base(name, strength, dexterity, intelligence)
        {
            //Adding the allowed weapons & armors when object is instantiated
            WeaponsAllowed.Add(WeaponTypes.STAFF);
            WeaponsAllowed.Add(WeaponTypes.WAND);
            ArmorsAllowed.Add(ArmorType.CLOTH);

        }

        #region Getters
  
        #endregion

        #region Equip weapon
        /// <summary>
        /// This method will try to equip a weapon if the weapon is allowed by this class.
        /// </summary>
        /// <param name="mage">This is the created character</param>
        /// <param name="weapon">This is the weapon that the character is trying to equip</param>
        public void EquipWeapon(Mage mage, Weapon weapon)
        {
            try
            {              
                if (CheckIfWeaponIsAllowed())
                {
                    base.setEquipments(weapon.GetItemSlot(), weapon.getItemName());
                }
                else
                {
                    throw new InvalidWeaponException();
                }

                base.getEquipments();
            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #region Check if weapon is allowed
            //Check if weapon is allowed
            bool CheckIfWeaponIsAllowed()
            {
                //Search for the weapon in the weapons list
                WeaponTypes newWeaponType = weapon.getWeaponType();               
                if (WeaponsAllowed.Contains(newWeaponType) && weapon.getRequiredLvl() <= mage.getLvl())
                {
                    //If weapons is in the list, return true;
                    return true;
                }
                else
                return false;               
            }

            #endregion

        }
        #endregion

        #region Equip Armor
        public void EquipArmor(Mage mage, Weapon weapon)
        {
            try
            {

                WeaponTypes newWeaponType = weapon.getWeaponType();
                if (newWeaponType == WeaponsAllowed[0] && weapon.getRequiredLvl() <= mage.getLvl())
                {
                    ///Exuip weapon
                    Console.WriteLine("You can equip this weapon");
                }
                else
                {
                    throw new InvalidWeaponException();
                }

            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        #endregion
    }
}
