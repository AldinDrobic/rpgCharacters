using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpgCharacters.Models.Characters;

namespace rpgCharacters.TestData.TestCharacters
{
    public static class TestDataCharacters
    {
        

        #region Mage data
        public static void MageData()
        {
            Mage mage = new Mage();
            Console.WriteLine(mage);
        }
        #endregion

        #region Ranger data
        public static void RangerData()
        {
            Ranger ranger = new Ranger();
            Console.WriteLine(ranger);
        }


        #endregion

        #region Rouge Data
        public static void RougeData()
        {
            Rouge rouge = new Rouge();
            Console.WriteLine(rouge);
        }
        #endregion

        #region Warrior Data
        public static void WarriorData()
        {
            Warrior warrior = new Warrior();
            Console.WriteLine(warrior);
        }
        #endregion
    }
}
