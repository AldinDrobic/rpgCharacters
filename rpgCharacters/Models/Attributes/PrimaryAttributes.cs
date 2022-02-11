using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    public class PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        /// <summary>
        /// Initializable constructor.
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        public PrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
        }

        /// <summary>
        /// Will increase strength with what ever value is passed in the parameter.
        /// </summary>
        /// <param name="increaseValue"></param>
        public void increaseStrength(int increaseValue)
        {
            this.Strength += increaseValue;
        }
        /// <summary>
        /// Will increase strength with what ever value is passed in the parameter.
        /// </summary>
        /// <param name="increaseValue"></param>
        public void increaseDexterity(int increaseValue)
        {
            this.Dexterity += increaseValue;
        }
        /// <summary>
        /// Will increase strength with what ever value is passed in the parameter.
        /// </summary>
        /// <param name="increaseValue"></param>
        public void increaseIntelligence(int increaseValue)
        {
            this.Intelligence += increaseValue;
        }
    }
}
