using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    public class Inventory
    {
        public int Size { get; }
        private Dictionary<int, Item> _ItemsInventory { get; set; }
    }
}
