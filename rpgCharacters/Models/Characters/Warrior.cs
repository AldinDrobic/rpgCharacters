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
    public class Warrior: Character
    {
        #region Private class variables
        private List<ArmorType> _armorsAllowed = new List<ArmorType>();
        private List<WeaponTypes> _weaponsAllowed = new List<WeaponTypes>();
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor to create a standard warrior object
        /// </summary>
        public Warrior()
        {
            base.SetPrimaryAttributes(5, 2, 1);
            base.SetCharacterType(CharacterTypes.Warrior);
            base.SetMainAttribute(base.GetPrimaryAttributes().Strength);
            AddAllowedArmorsWeapons();
        }
        #endregion

        #region Allowed armors & weapons

        /// <summary>
        /// Will fill list with allowed armors and weapon that warrior can equip
        /// </summary>
        private void AddAllowedArmorsWeapons()
        {
            _armorsAllowed.Add(ArmorType.MAIL);
            _armorsAllowed.Add(ArmorType.PLATE);
            _weaponsAllowed.Add(WeaponTypes.AXE);
            _weaponsAllowed.Add(WeaponTypes.HAMMER);
            _weaponsAllowed.Add(WeaponTypes.SWORD);
        }
        #endregion

        #region Lvl up character
        /// <summary>
        /// Used to increase characters lvl
        /// </summary>
        public string CharacterLvlUp()
        {
            return base.CharacterLvlUp(3, 2, 1);
        }
        #endregion

        #region Equip weapon
        /// <summary>
        /// This method will try to equip a weapon if the weapon is allowed by this class.
        /// </summary>
        /// <param name="warrior">This is the created character</param>
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
                //Search for the weapon in the Warriors list of allowed weapons             
                if (_weaponsAllowed.Contains(weapon.GetWeaponType()) && weapon.GetRequiredLvl() <= base.GetLvl())
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
            if (!IsfArmorAllowed())
                    throw new InvalidArmorException();

            equippedArmorMessage = base.SetArmorIntoEquipments(armor);
            return equippedArmorMessage;
            #region Check if armor is allowed
            bool IsfArmorAllowed()
            {
                //Search for the armor in the Mages list of allowed armors 
                if (this._armorsAllowed.Contains(armor.GetArmorType()) && armor.GetRequiredLvl() <= base.GetLvl())
                    return true;
                else
                    return false;
            }
            #endregion

        }
        #endregion

    }
}
