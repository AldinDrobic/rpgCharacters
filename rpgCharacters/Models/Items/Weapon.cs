using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    public class Weapon : Item
    {

        Enum WeaponType;
        

        public Weapon(string itemName, int itemLvl, Enum itemSlot, Enum weaponType) 
            :base(itemName, itemLvl, itemSlot)
        {
           this.WeaponType = Weapons.Axe;
        }

       
    }
}
