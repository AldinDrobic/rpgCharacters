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
                    base.setEquipments(weapon.GetItemSlot(), weapon.getItemName());
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
                if (WeaponsAllowed.Contains(weapon.getWeaponType()) && weapon.getRequiredLvl() <= mage.getLvl())              
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
                    base.setEquipments(armor.GetItemSlot(), armor.getItemName());
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
                if (ArmorsAllowed.Contains(armor.GetArmorType()) && armor.getRequiredLvl() <= mage.getLvl())
                    return true;
                else
                    return false;
            }
            #endregion

        }
        #endregion
    }
}
