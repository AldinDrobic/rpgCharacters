using rpgCharacters.Models.Items;
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
        public static Armor getClotHelmet()
        {
            return clothHelmet;
        }
        public static Armor getClothArmor()
        {
            return clothArmor;
        }
        public static Armor getClothLegs()
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
        public static Armor getLeatherHelmet()
        {
            return leatherHelmet;
        }
        public static Armor getLeaterArmor()
        {
            return leatherArmor;
        }
        public static Armor getLeatherLegs()
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
        public static Armor getHelmet()
        {
            return mailHelmet;
        }
        public static Armor getArmor()
        {
            return mailArmor;
        }
        public static Armor getLegs()
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
        public static Armor getPlateHelmet()
        {
            return plateHelmet;
        }
        public static Armor getPlateArmor()
        {
            return plateArmor;
        }
        public static Armor getPlateLegs()
        {
            return plateLegs;
        }

        #endregion
        #endregion
    }
}
