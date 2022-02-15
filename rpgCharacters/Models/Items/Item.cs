using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    public abstract class Item
    {
        private string _itemName;
        private int _itemLvl;
        private ItemSlot _itemSlot;

        public Item()
        {

        }
        public Item(string itemName, int itemLvl, ItemSlot itemSlot)
        {
            this._itemName = itemName;
            this._itemLvl = itemLvl;
            this._itemSlot = itemSlot;
        }


        #region Getters

        /// <summary>
        /// Returns items name
        /// </summary>
        /// <returns></returns>
        public string GetItemName()
        {
            return this._itemName;
        }
        /// <summary>
        /// Returns items required lvl
        /// </summary>
        /// <returns></returns>
        public int GetRequiredLvl()
        {
            return this._itemLvl;
        }
        /// <summary>
        /// Returns items slot
        /// </summary>
        /// <returns></returns>
        public ItemSlot GetItemSlot()
        {
            return this._itemSlot;
        }

        #endregion

    }
}
