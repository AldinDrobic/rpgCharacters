using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Items
{
    public class Armor: Item
    {
        private ArmorType _type;
        public Armor(string itemName, int itemLvl, ItemSlot itemSlot, ArmorType armorType)
            : base(itemName, itemLvl, itemSlot)
        {
            this._type = armorType;
        }

        #region Return a armor type
        /// <summary>
        /// Returns type of armor
        /// </summary>
        /// <returns></returns>
        public ArmorType GetArmorType()
        {
            return this._type;
        }
        #endregion

    }
}
