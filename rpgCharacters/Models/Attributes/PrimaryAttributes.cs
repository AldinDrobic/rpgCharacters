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
        /// Will increase Strength with what ever value is passed in the parameter.
        /// </summary>
        /// <param name="increaseValue"></param>
        public void IncreaseStrength(int increaseValue)
        {
            this.Strength += increaseValue;
        }
        /// <summary>
        /// Will increase Strength with what ever value is passed in the parameter.
        /// </summary>
        /// <param name="increaseValue"></param>
        public void IncreaseDexterity(int increaseValue)
        {
            this.Dexterity += increaseValue;
        }
        /// <summary>
        /// Will increase Strength with what ever value is passed in the parameter.
        /// </summary>
        /// <param name="increaseValue"></param>
        public void IncreaseIntelligence(int increaseValue)
        {
            this.Intelligence += increaseValue;
        }
    }
}
