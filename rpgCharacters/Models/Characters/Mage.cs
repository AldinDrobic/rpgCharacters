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
        public List<ArmorType> ArmorsAllowed { get; set; }
        public List<WeaponTypes> WeaponsAllowed { get; set; }
        public Mage(string name, int strength, int dexterity, int intelligence)
            :base(name, strength, dexterity, intelligence)
        {
            WeaponsAllowed.Add(WeaponTypes.STAFF);
            ArmorsAllowed.Add(ArmorType.CLOTH);


        }

        public override void EquipWeapon(WeaponTypes weapon, List<WeaponTypes> allowedWeapons)
        {

        }
    }
}
