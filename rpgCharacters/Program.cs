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


            //FORTSÄTT MED ATT LÄGGA TILL ARMOR. KOLLA OM DU KAN LÄGGA TILL TVÅ LEGS, EQUIPMENT LISTAN BÖR INTE TILLÅTA DETTA!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            //Ok
            TestMageData.testMage1.EquipArmor(TestMageData.testMage1, TestArmorData.GetClothArmor());
            TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.GetTestStaff());

            //NOK
            TestMageData.testMage1.EquipArmor(TestMageData.testMage1, TestArmorData.GetPlateArmor());
            TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.GetTestAxe());

            Mage mage = new Mage(1, 1, 1);

            Console.WriteLine(mage.GetName());





        }
    }
}
