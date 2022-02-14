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

        /// <summary>
        /// This method will try to equip a weapon if the weapon is allowed by this class.
        /// </summary>
        /// <param name="weapon">This is the weapon that is trying to be equiped</param>
        public void EquipWeapon(Weapon weapon, Mage mage)
        {
            try
            {
                WeaponTypes newWeaponType = weapon.getWeaponType();
                if (newWeaponType == WeaponsAllowed[0] && weapon.getRequiredLvl() <= mage.getLvl())
                {
                    Console.WriteLine("You can equip this weapon");
                }
                else
                {
                    Console.WriteLine("You can't equip this weapon");
                }

            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Check if char lvl is high enough to equip weapon
        }
    }
}
