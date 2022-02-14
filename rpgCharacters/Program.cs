using rpgCharacters.Models;
using rpgCharacters.Models.Characters;
using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using rpgCharacters.TestData;
using System;
using System.Collections.Generic;

namespace rpgCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.getTestStaff());
            TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.getTestStaff());
            TestMageData.testMage1.EquipWeapon(TestMageData.testMage1, TestWeaponData.getTestBow());
        }
    }
}
