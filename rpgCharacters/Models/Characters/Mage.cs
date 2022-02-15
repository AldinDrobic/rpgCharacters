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

        private List<ArmorType> _armorsAllowed = new List<ArmorType>();
        private List<WeaponTypes> _weaponsAllowed = new List<WeaponTypes>();
        public Mage(string name, int strength, int dexterity, int intelligence)
            :base(name, strength, dexterity, intelligence)
        {
            //Adding the allowed weapons & armors when object is instantiated
            _weaponsAllowed.Add(WeaponTypes.STAFF);
            _weaponsAllowed.Add(WeaponTypes.WAND);
            _armorsAllowed.Add(ArmorType.CLOTH);

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
                    base.SetEquipments(weapon.GetItemSlot(), weapon.GetItemName());
                else
                    throw new InvalidWeaponException();
            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #region Check if weapon is allowed
            bool CheckIfWeaponIsAllowed()
            {
                //Search for the weapon in the Mages list of allowed weapons             
                if (_weaponsAllowed.Contains(weapon.getWeaponType()) && weapon.GetRequiredLvl() <= mage.GetLvl())              
                    return true;
                else
                return false;               
            }

            #endregion

        }
        #endregion

        #region Equip Armor
        public void EquipArmor(Mage mage, Armor armor)
        {
            try
            {
                if (CheckIfArmorIsAllowed())
                    base.SetEquipments(armor.GetItemSlot(), armor.GetItemName());
                else
                    throw new InvalidArmorException();
            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #region Check if armor is allowed
            bool CheckIfArmorIsAllowed()
            {
                Console.WriteLine(armor.GetArmorType());
                //Search for the armor in the Mages list of allowed armors 
                if (_armorsAllowed.Contains(armor.GetArmorType()) && armor.GetRequiredLvl() <= mage.GetLvl())
                    return true;
                else
                    return false;
            }
            #endregion

        }
        #endregion
    }
}
