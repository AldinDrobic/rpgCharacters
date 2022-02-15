﻿using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.TestData.TestItems
{
    public static class TestArmorData
    {
        #region Cloth set
        private static Armor clothHelmet = new Armor("Cloth helmet", 1, ItemSlot.HEAD, ArmorType.CLOTH);
        private static Armor clothArmor = new Armor("Cloth armor", 1, ItemSlot.BODY, ArmorType.CLOTH);
        private static Armor clothLegs = new Armor("Cloth legs", 1, ItemSlot.LEGS, ArmorType.CLOTH);

        #region Getters
        public static Armor GetClotHelmet()
        {
            return clothHelmet;
        }
        public static Armor GetClothArmor()
        {
            return clothArmor;
        }
        public static Armor GetClothLegs()
        {
            return clothLegs;
        }

        #endregion

        #endregion

        #region Leather set
        private static Armor leatherHelmet = new Armor("Leather helmet", 1, ItemSlot.HEAD, ArmorType.LEATHER);
        private static Armor leatherArmor = new Armor("Leather armor", 1, ItemSlot.BODY, ArmorType.LEATHER);
        private static Armor leatherLegs = new Armor("Leather legs", 1, ItemSlot.LEGS, ArmorType.LEATHER);

        #region Getters
        public static Armor GetLeatherHelmet()
        {
            return leatherHelmet;
        }
        public static Armor GetLeaterArmor()
        {
            return leatherArmor;
        }
        public static Armor GetLeatherLegs()
        {
            return leatherLegs;
        }
        #endregion
        #endregion

        #region Mail set
        private static Armor mailHelmet = new Armor("Mail helmet", 1, ItemSlot.HEAD, ArmorType.MAIL);
        private static Armor mailArmor = new Armor("Mail armor", 1, ItemSlot.BODY, ArmorType.MAIL);
        private static Armor mailLegs = new Armor("Mail legs", 1, ItemSlot.LEGS, ArmorType.MAIL);

        #region Getters
        public static Armor GetMailHelmet()
        {
            return mailHelmet;
        }
        public static Armor GetMailArmor()
        {
            return mailArmor;
        }
        public static Armor GetMailLegs()
        {
            return mailLegs;
        }
        #endregion
        #endregion

        #region Plate set
        private static Armor plateHelmet = new Armor("Plate helmet", 1, ItemSlot.HEAD, ArmorType.PLATE);
        private static Armor plateArmor = new Armor("Plate armor", 1, ItemSlot.BODY, ArmorType.PLATE);
        private static Armor plateLegs = new Armor("Plate legs", 1, ItemSlot.LEGS, ArmorType.PLATE);

        #region Getters
        public static Armor GetPlateHelmet()
        {
            return plateHelmet;
        }
        public static Armor GetPlateArmor()
        {
            return plateArmor;
        }
        public static Armor GetPlateLegs()
        {
            return plateLegs;
        }

        #endregion
        #endregion
    }
}
