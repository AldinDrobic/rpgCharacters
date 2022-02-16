using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Attributes
{
    public class ArmorAttributes
    {
        public double Defence{ get; set; }

        /// <summary>
        /// Constructor to increase character power
        /// </summary>
        /// <param name="defence">Will increase character power</param>
        public ArmorAttributes(double defence)
        {
            this.Defence = defence;
        }
    }
}
