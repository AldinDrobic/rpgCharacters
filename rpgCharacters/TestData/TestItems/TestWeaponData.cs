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
        private static Weapon Axe = new Weapon("AXE", 1, ItemSlot.WEAPON, WeaponTypes.AXE, 1, 1);
        private static Weapon Bow = new Weapon("BOW", 1, ItemSlot.WEAPON, WeaponTypes.BOW, 1, 1);
        private static Weapon Dagger = new Weapon("DAGGER", 1, ItemSlot.WEAPON, WeaponTypes.DAGGER, 1, 1);
        private static Weapon Hammer = new Weapon("HAMMER", 1, ItemSlot.WEAPON, WeaponTypes.HAMMER, 1, 1);
        private static Weapon Staff = new Weapon("STAFF", 1, ItemSlot.WEAPON, WeaponTypes.STAFF, 1, 1);
        private static Weapon Sword = new Weapon("Sword", 1, ItemSlot.WEAPON, WeaponTypes.SWORD, 1, 1);
        private static Weapon Wand = new Weapon("Wand", 1, ItemSlot.WEAPON, WeaponTypes.WAND, 1, 1);


        public static Weapon getTestAxe()
        {
            return Axe;
        }
        public static Weapon getTestBow()
        {
            return Bow;
        }
        public static Weapon getTestDagger()
        {
            return Dagger;
        }
        public static Weapon getTestHammer()
        {
            return Hammer;
        }
        public static Weapon getTestStaff()
        {
            return Staff;
        }
        public static Weapon getTestSword()
        {
            return Sword;
        }
        public static Weapon getTestWand()
        {
            return Wand;
        }
    }
}
