using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using rpgCharacters.Models.Characters.Abstract;

namespace rpgCharacters.Models.Characters
{
    public class Ranger: Character
    {
        #region Private class variables
        private List<ArmorType> _armorsAllowed = new List<ArmorType>();
        private List<WeaponTypes> _weaponsAllowed = new List<WeaponTypes>();
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor for instantiating new objects
        /// </summary>
        public Ranger()
        {
            base.SetPrimaryAttributes(1, 7, 1);
            base.SetCharacterType(CharacterTypes.Ranger);
            base.SetMainAttribute(base.GetPrimaryAttributes().Dexterity);
            AddAllowedArmorsWeapons();
        }
        #endregion

        #region Allowed armors & weapons
        /// <summary>
        /// Will fill list with allowed armors and weapon that rangers can equip
        /// </summary>
        private void AddAllowedArmorsWeapons()
        {
            _armorsAllowed.Add(ArmorType.LEATHER);
            _armorsAllowed.Add(ArmorType.MAIL);
            _weaponsAllowed.Add(WeaponTypes.BOW);
        }


        #endregion

        #region Lvl up character
        /// <summary>
        /// Used to increase character lvl
        /// </summary>
        public void CharacterLvlUp()
        {
            base.CharacterLvlUp(1, 5, 1);
        }

        #endregion

        #region Equip weapon
        /// <summary>
        /// This method will try to equip a weapon if the weapon is allowed by this class.
        /// </summary>
        /// <param name="ranger">This is the created character</param>
        /// <param name="weapon">This is the weapon that the character is trying to equip</param>
        public string EquipWeapon(Weapon weapon)
        {
            string equippedWeaponMessage = "";
            if (!IsWeaponAllowed())
                throw new InvalidWeaponException("Your class is not allowed to equip this weapon");

            equippedWeaponMessage = base.SetWeaponIntoEquipments(weapon);
            #region Check if weapon is allowed
            bool IsWeaponAllowed()
            {
                //Search for the weapon in the Rangers list of allowed weapons             
                if (this._weaponsAllowed.Contains(weapon.GetWeaponType()) && weapon.GetRequiredLvl() <= base.GetLvl())
                    return true;
                else
                    return false;
            }

            #endregion
            return equippedWeaponMessage;
        }
        #endregion

        #region Equip Armor
        /// <summary>
        /// This method will try to equip a armor if it is allowed by the class
        /// </summary>
        public string EquipArmor(Armor armor)
        {
            string equippedArmorMessage = "";
            if (!IsArmorAllowed())
                throw new InvalidArmorException();

            equippedArmorMessage = base.SetArmorIntoEquipments(armor);
            #region Check if armor is allowed
            bool IsArmorAllowed()
            {
                //Search for the armor in the Rangers list of allowed armors 
                if (this._armorsAllowed.Contains(armor.GetArmorType()) && armor.GetRequiredLvl() <= base.GetLvl())
                    return true;
                else
                    return false;
            }
            #endregion
            return equippedArmorMessage;
        }
        #endregion
    }
}
