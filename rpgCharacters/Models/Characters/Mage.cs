using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;

namespace rpgCharacters.Models.Characters
{
    public class Mage: Character
    {
        #region Private class variables
        private List<ArmorType> _armorsAllowed = new List<ArmorType>();
        private List<WeaponTypes> _weaponsAllowed = new List<WeaponTypes>();
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor to create a standard mage object
        /// </summary>
        public Mage()
        {
            base.SetPrimaryAttributes(1, 1, 8);
            base.SetCharacterType(CharacterTypes.Mage);
            base.SetMainAttribute(base.GetPrimaryAttributes().Intelligence);
            AddAllowedArmorsWeapons();
        }
        #endregion

        #region Allowed armors & weapons

        /// <summary>
        /// Will fill list with allowed armors and weapon that mage can equip
        /// </summary>
        private void AddAllowedArmorsWeapons()
        {
            _armorsAllowed.Add(ArmorType.CLOTH);
            _weaponsAllowed.Add(WeaponTypes.STAFF);
            _weaponsAllowed.Add(WeaponTypes.WAND);
        }
        #endregion

        #region Getters

        #endregion

        #region Lvl up character
        /// <summary>
        /// Used to increase characters lvl
        /// </summary>
        public void CharacterLvlUp()
        {
            base.CharacterLvlUp(1, 1, 5);
        }
        #endregion

        #region Equip weapon
        /// <summary>
        /// This method will try to equip a weapon if the weapon is allowed by this class.
        /// </summary>
        /// <param name="mage">This is the created character</param>
        /// <param name="weapon">This is the weapon that the character is trying to equip</param>
        public string EquipWeapon(Mage mage, Weapon weapon)
        {
            string equippedWeaponMessage = "";
            try
            {              
                if (CheckIfWeaponIsAllowed())
                    equippedWeaponMessage = base.SetWeaponIntoEquipments(weapon);
                else
                    throw new InvalidWeaponException();
            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return equippedWeaponMessage;
            #region Check if weapon is allowed
            bool CheckIfWeaponIsAllowed()
            {
                //Search for the weapon in the Mages list of allowed weapons             
                if (_weaponsAllowed.Contains(weapon.GetWeaponType()) && weapon.GetRequiredLvl() <= mage.GetLvl())              
                    return true;
                else
                return false;               
            }

            #endregion
        }
        #endregion

        #region Equip Armor
        /// <summary>
        /// This method will try to equip a armor if it is allowed by the class
        /// </summary>
        public string EquipArmor(Mage mage, Armor armor)
        {
            string equippedArmorMessage = "";
            try
            {
                if (CheckIfArmorIsAllowed())
                    equippedArmorMessage = base.SetArmorIntoEquipments(armor.GetItemSlot(), armor.GetItemName());
                else
                    throw new InvalidArmorException();
            }
            catch (InvalidArmorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return equippedArmorMessage;
            #region Check if armor is allowed
            bool CheckIfArmorIsAllowed()
            {
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
