using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;

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
        /// <param name="characterType">Type of character, eg Ranger</param>
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
            base.CharacterLvlUp(1, 1, 5);
        }

        #endregion

        #region Equip weapon
        /// <summary>
        /// This method will try to equip a weapon if the weapon is allowed by this class.
        /// </summary>
        /// <param name="ranger">This is the created character</param>
        /// <param name="weapon">This is the weapon that the character is trying to equip</param>
        public void EquipWeapon(Ranger ranger, Weapon weapon)
        {
            try
            {
                if (CheckIfWeaponIsAllowed())
                    base.SetWeaponIntoEquipments(weapon, ranger.GetPrimaryAttributes().Intelligence);
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
                if (_weaponsAllowed.Contains(weapon.GetWeaponType()) && weapon.GetRequiredLvl() <= ranger.GetLvl())
                    return true;
                else
                    return false;
            }

            #endregion
        }
        #endregion

        #region Equip Armor
        public void EquipArmor(Ranger ranger, Armor armor)
        {
            try
            {
                if (CheckIfArmorIsAllowed())
                    base.SetArmorIntoEquipments(armor.GetItemSlot(), armor.GetItemName());
                else
                    throw new InvalidArmorException();
            }
            catch (InvalidArmorException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #region Check if armor is allowed
            bool CheckIfArmorIsAllowed()
            {
                //Search for the armor in the Mages list of allowed armors 
                if (_armorsAllowed.Contains(armor.GetArmorType()) && armor.GetRequiredLvl() <= ranger.GetLvl())
                    return true;
                else
                    return false;
            }
            #endregion
        }
        #endregion
    }
}
