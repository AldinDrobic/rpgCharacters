using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    public abstract class Item
    {
        string ItemName;
        int ItemLvl;
        Enum ItemSlot;
        public enum Slot
        {
            SLOT_HEAD,
            SLOT_BODY,
            SLOT_LEGS,
            SLOT_WEAPON
        }

        public Item(string itemName, int itemLvl, Enum itemSlot)
        {
            this.ItemName = itemName;
            this.ItemLvl = itemLvl;
            this.ItemSlot = itemSlot;
        }

    }
}
