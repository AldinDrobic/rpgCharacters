using rpgCharacters.Models;
using rpgCharacters.Models.Characters;
using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;

namespace rpgCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weapon weapon1 = new Weapon("STAFF", 1, ItemSlot.WEAPON, WeaponTypes.STAFF, 1, 1);
            Weapon weapon = new Weapon("AXE", 1, ItemSlot.WEAPON, WeaponTypes.AXE, 1, 1);
            Mage mage = new Mage("Aldin", 1, 1, 1);


            mage.EquipWeapon(weapon);

            //weapons.Add(new WeaponTypes());



        }
    }
}
