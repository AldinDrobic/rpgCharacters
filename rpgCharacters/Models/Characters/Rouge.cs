using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public string EquipWeapon(Rouge Rouge, Weapon weapon)
        {
            string equippedWeaponMessage = "";
            try
            {
                if (CheckIfWeaponIsAllowed())
                    equippedWeaponMessage = base.SetWeaponIntoEquipments(weapon, Rouge.GetPrimaryAttributes().Dexterity);
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
                if (_weaponsAllowed.Contains(weapon.GetWeaponType()) && weapon.GetRequiredLvl() <= Rouge.GetLvl())
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
        public string EquipArmor(Rouge rouge, Armor armor)
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
                if (_armorsAllowed.Contains(armor.GetArmorType()) && armor.GetRequiredLvl() <= rouge.GetLvl())
                    return true;
                else
                    return false;
            }
            #endregion
        }
        #endregion
    }
}
