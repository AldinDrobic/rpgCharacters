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
        private string ItemName;
        private int ItemLvl;
        private ItemSlot ItemSlot;
        

        public Item(string itemName, int itemLvl, ItemSlot itemSlot)
        {
            this.ItemName = itemName;
            this.ItemLvl = itemLvl;
            this.ItemSlot = itemSlot;
        }

        /// <summary>
        /// Returns items name
        /// </summary>
        /// <returns></returns>
        public string getItemName()
        {
            return this.ItemName;
        }
        /// <summary>
        /// Returns items required lvl
        /// </summary>
        /// <returns></returns>
        public int getRequiredLvl()
        {
            return this.ItemLvl;
        }
        /// <summary>
        /// Returns items slot
        /// </summary>
        /// <returns></returns>
        public ItemSlot GetItemSlot()
        {
            return this.ItemSlot;
        }
    }
}
