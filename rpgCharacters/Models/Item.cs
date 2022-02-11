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
        string ItemLvl;   
        public enum Slot
        {
            SLOT_HEAD,
            SLOT_BODY,
            SLOT_LEGS,
            SLOT_WEAPON
        }

    }
}
