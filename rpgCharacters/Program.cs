using rpgCharacters.Models;
using rpgCharacters.Models.Characters;
using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using rpgCharacters.TestData;
using rpgCharacters.TestData.TestItems;
using System;
using System.Collections.Generic;

namespace rpgCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.GetTestStaff());
            //TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.GetTestStaff());
            //TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.GetTestBow());

            ////Ok
            //TestMageData.testMage1.EquipArmor(TestMageData.testMage1, TestArmorData.GetClothArmor());
            //TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.GetTestStaff());

            ////NOK
            //TestMageData.testMage1.EquipArmor(TestMageData.testMage1, TestArmorData.GetPlateArmor());
            //TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.GetTestAxe());
            Mage mage1 = new Mage();
            Mage mage = new Mage();
            //mage.EquipWeapon(mage, TestWeaponData.GetTestStaff());
            //mage.EquipArmor(mage, TestArmorData.GetClothArmor());

            Console.WriteLine(mage);




        }
    }
}
