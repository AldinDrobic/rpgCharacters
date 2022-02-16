using rpgCharacters.Models;
using rpgCharacters.Models.Characters;
using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using rpgCharacters.TestData;
using rpgCharacters.TestData.TestItems;
using System;
using System.Collections.Generic;
using rpgCharacters.Models.Attributes;
using rpgCharacters.TestData.TestCharacters;

namespace rpgCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Weapon axe = new Weapon("Axe", 1, ItemSlot.WEAPON, WeaponTypes.AXE, new WeaponAttributes(7, 1.1));
            Armor armor = new Armor("Plate armor", 1, ItemSlot.BODY, ArmorType.PLATE, new ArmorAttributes(1));
            warrior.EquipWeapon(axe);
            warrior.EquipArmor(armor);
            Console.WriteLine(warrior);
            warrior.DealDamage();
            var damage = warrior.GetCharacterDamage();
        }
    }
}
