using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpgCharacters.Models.Characters.Abstract;
using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;

namespace rpgCharacters.Models.Characters
{
    public class Rouge: Character
    {
        #region Private class variables
        private List<ArmorType> _armorsAllowed = new List<ArmorType>();
        private List<WeaponTypes> _weaponsAllowed = new List<WeaponTypes>();
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor to create a standard Rouge object
        /// </summary>
        public Rouge()
        {
            base.SetPrimaryAttributes(2, 6, 1);
            base.SetCharacterType(CharacterTypes.Rouge);
            base.SetMainAttribute(base.GetPrimaryAttributes().Dexterity);
            AddAllowedArmorsWeapons();
        }
        #endregion

        #region Allowed armors & weapons

        /// <summary>
        /// Will fill list with allowed armors and weapon that Rouge can equip
        /// </summary>
        private void AddAllowedArmorsWeapons()
        {
            _armorsAllowed.Add(ArmorType.LEATHER);
            _armorsAllowed.Add(ArmorType.MAIL);
            _weaponsAllowed.Add(WeaponTypes.DAGGER);
            _weaponsAllowed.Add(WeaponTypes.SWORD);
        }
        #endregion

        #region Lvl up character
        /// <summary>
        /// Used to increase characters lvl
        /// </summary>
        public void CharacterLvlUp()
        {
            base.CharacterLvlUp(1, 4, 1);
        }
        #endregion

        #region Equip weapon
        /// <summary>
        /// This method will try to equip a weapon if the weapon is allowed by this class.
        /// </summary>
        /// <param name="Rouge">This is the created character</param>
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
                //Search for the weapon in the Rouges list of allowed weapons             
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
                //Search for the armor in the Rouges list of allowed armors 
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
