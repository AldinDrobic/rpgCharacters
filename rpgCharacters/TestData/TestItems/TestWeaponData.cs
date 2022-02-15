using rpgCharacters.Models;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.TestData
{
    public static class TestWeaponData
    {
        private static Weapon Axe = new Weapon("AXE", 1, ItemSlot.WEAPON, WeaponTypes.AXE, 25.5, 0.5);
        private static Weapon Bow = new Weapon("BOW", 1, ItemSlot.WEAPON, WeaponTypes.BOW, 12.3, 1.5);
        private static Weapon Dagger = new Weapon("DAGGER", 1, ItemSlot.WEAPON, WeaponTypes.DAGGER, 5.5, 7.8);
        private static Weapon Hammer = new Weapon("HAMMER", 1, ItemSlot.WEAPON, WeaponTypes.HAMMER, 35.7, 0.2);
        private static Weapon Staff = new Weapon("STAFF", 1, ItemSlot.WEAPON, WeaponTypes.STAFF, 6.7, 6.8);
        private static Weapon Sword = new Weapon("Sword", 1, ItemSlot.WEAPON, WeaponTypes.SWORD, 15.3, 4.6);
        private static Weapon Wand = new Weapon("Wand", 1, ItemSlot.WEAPON, WeaponTypes.WAND, 7, 19.2);


        public static Weapon GetTestAxe()
        {
            return Axe;
        }
        public static Weapon GetTestBow()
        {
            return Bow;
        }
        public static Weapon GetTestDagger()
        {
            return Dagger;
        }
        public static Weapon GetTestHammer()
        {
            return Hammer;
        }
        public static Weapon GetTestStaff()
        {
            return Staff;
        }
        public static Weapon GetTestSword()
        {
            return Sword;
        }
        public static Weapon GetTestWand()
        {
            return Wand;
        }
    }
}
