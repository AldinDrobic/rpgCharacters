using rpgCharacters.Models;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpgCharacters.Models.Attributes;

namespace rpgCharacters.TestData
{
    public static class TestWeaponData
    {
        private static readonly Weapon Axe = new Weapon("AXE", 2, ItemSlot.WEAPON, WeaponTypes.AXE, new WeaponAttributes(25.5, 0.5));
        private static readonly Weapon Bow = new Weapon("BOW", 2, ItemSlot.WEAPON, WeaponTypes.BOW, new WeaponAttributes(12.3, 1.5));
        private static readonly Weapon Dagger = new Weapon("DAGGER", 2, ItemSlot.WEAPON, WeaponTypes.DAGGER, new WeaponAttributes(5.5, 7.8));
        private static readonly Weapon Hammer = new Weapon("HAMMER", 2, ItemSlot.WEAPON, WeaponTypes.HAMMER, new WeaponAttributes(35.7, 0.2));
        private static readonly Weapon Staff = new Weapon("STAFF", 2, ItemSlot.WEAPON, WeaponTypes.STAFF, new WeaponAttributes(6.7, 6.8));
        private static readonly Weapon Sword = new Weapon("SWORD", 2, ItemSlot.WEAPON, WeaponTypes.SWORD, new WeaponAttributes(15.3, 4.6));
        private static readonly Weapon Wand = new Weapon("WAND", 2, ItemSlot.WEAPON, WeaponTypes.WAND, new WeaponAttributes(7, 19.2));


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
