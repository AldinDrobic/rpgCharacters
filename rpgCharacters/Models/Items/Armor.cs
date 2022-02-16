using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpgCharacters.Models.Attributes;

namespace rpgCharacters.Models.Items
{
    public class Armor: Item
    {
        private ArmorType _armorType;
        private ArmorAttributes _armorAttributes;
        public Armor(string itemName, int itemLvl, ItemSlot itemSlot, ArmorType armorType, ArmorAttributes armorAttributes)
            : base(itemName, itemLvl, itemSlot)
        {
            this._armorType = armorType;
            this._armorAttributes = armorAttributes;
        }

        #region Getters
        /// <summary>
        /// Returns type of armor
        /// </summary>
        /// <returns></returns>
        public ArmorType GetArmorType()
        {
            return this._armorType;
        }
        /// <summary>
        /// Get armor attributes
        /// </summary>
        /// <returns></returns>
        public ArmorAttributes GetArmorAttributes()
        {
            return this._armorAttributes;
        }
        #endregion

    }
}
