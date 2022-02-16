using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Attributes
{
    public class ArmorAttributes
    {
        public double Damage{ get; set; }
        /// <summary>
        /// Constructor to increase character power
        /// </summary>
        /// <param name="damage">Will increase character power</param>
        public ArmorAttributes(double damage)
        {
            this.Damage = damage;
        }
    }
}
