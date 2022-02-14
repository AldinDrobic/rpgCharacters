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
        //public List<ArmorType> ArmorsAllowed { get; set; }
        //public List<WeaponTypes> WeaponsAllowed { get; set; }

        public List<WeaponTypes> WeaponsAllowed = new List<WeaponTypes>();
        public Mage(string name, int strength, int dexterity, int intelligence)
            :base(name, strength, dexterity, intelligence)
        {
            WeaponsAllowed.Add(WeaponTypes.STAFF);
            //ArmorsAllowed.Add(ArmorType.CLOTH);


        }

        public void EquipWeapon(Weapon weapon)
        {
            try
            {
                WeaponTypes newWeaponType = weapon.getWeaponType();
                //Du måste ha objektet vapen här. Du måste skicka in ett helt vapen objekt till denna metod.
                if (newWeaponType == WeaponsAllowed[0])
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

            //Check if weapon is allowed by char class
            //Check if char lvl is high enough to equip weapon
        }
    }
}
