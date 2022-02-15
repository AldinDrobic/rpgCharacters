using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Characters
{
    public class Mage: Character
    {

        private List<ArmorType> _armorsAllowed = new List<ArmorType>();
        private List<WeaponTypes> _weaponsAllowed = new List<WeaponTypes>();

        #region Constructors

        /// <summary>
        /// Constructor to create a standard mage object
        /// </summary>
        public Mage()
        {
            base.SetPrimaryAttributes(1, 1, 8);
            AddAllowedArmorsWeapons();
        }
        /// <summary>
        /// Constructor for instantiating new objects
        /// </summary>
        /// <param name="strength">Characters strength</param>
        /// <param name="dexterity">Characters dexterity</param>
        /// <param name="intelligence">Characters intelligence</param>
        public Mage(int strength, int dexterity, int intelligence)
            : base(strength, dexterity, intelligence)
        {
            AddAllowedArmorsWeapons();
        }
        /// <summary>
        /// Constructor for instantiating new objects
        /// </summary>
        /// <param name="name">Name of character</param>
        /// <param name="strength">Characters strength</param>
        /// <param name="dexterity">Characters dexterity</param>
        /// <param name="intelligence">Characters intelligence</param>
        public Mage(string name, int strength, int dexterity, int intelligence)
            : base(name, strength, dexterity, intelligence)
        {
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

        public void CharacterLvlUp()
        {
            base.CharacterLvlUp(1, 1, 5);
        }

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
                    base.SetWeaponIntoEquipments(weapon, mage.GetPrimaryAttributes().Intelligence);
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
                if (_weaponsAllowed.Contains(weapon.GetWeaponType()) && weapon.GetRequiredLvl() <= mage.GetLvl())              
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
