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
        

        public Item(string itemName, int itemLvl)
        {
            this.ItemName = itemName;
            this.ItemLvl = itemLvl;
        }

    }
}
