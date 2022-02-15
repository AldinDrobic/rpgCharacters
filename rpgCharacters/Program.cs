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

            ////Mage
            //TestDataCharacters.PrintMageData();
            //TestDataCharacters.IncreaseMageLvl();
            //TestDataCharacters.PrintMageData();


            ////Ranger
            //TestDataCharacters.PrintRangerData();
            //TestDataCharacters.IncreaseRangerLvl();
            //TestDataCharacters.PrintRangerData();


            ////Rouge
            //TestDataCharacters.PrintRougeData();
            //TestDataCharacters.IncreaseRougeLvl();
            //TestDataCharacters.PrintRougeData();


            ////Warrior
            //TestDataCharacters.PrintWarriorData();
            //TestDataCharacters.IncreaseWarriorLvl();
            //TestDataCharacters.PrintWarriorData();

            Weapon fireAxe = new Weapon("Fire axe", 1, ItemSlot.WEAPON, WeaponTypes.AXE, 
                new WeaponAttributes(20, 2));
            Weapon regularAxe = new Weapon("Regular axe", 1, ItemSlot.WEAPON, WeaponTypes.AXE,
                new WeaponAttributes(1, 1));

            Armor plateArmor = new Armor("Plate armor", 1, ItemSlot.BODY, ArmorType.PLATE);
            Armor mailArmor = new Armor("Mail armor", 1, ItemSlot.BODY, ArmorType.MAIL);

            TestDataCharacters.warrior.EquipWeapon(TestDataCharacters.warrior, fireAxe);
            TestDataCharacters.warrior.EquipWeapon(TestDataCharacters.warrior, regularAxe);
            TestDataCharacters.warrior.EquipArmor(TestDataCharacters.warrior, mailArmor);
            TestDataCharacters.warrior.EquipArmor(TestDataCharacters.warrior, plateArmor);








        }
    }
}
