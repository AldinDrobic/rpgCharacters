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
        public static Mage mage = new Mage();
        public static Ranger ranger = new Ranger();
        public static Rouge rouge = new Rouge();
        public static Warrior warrior = new Warrior();




        #region Mage data
        public static void PrintMageData() {Console.WriteLine(mage);}
        public static void IncreaseMageLvl() {mage.CharacterLvlUp();}
        #endregion




        #region Ranger data
        public static void PrintRangerData(){ Console.WriteLine(ranger);}
        public static void IncreaseRangerLvl() { ranger.CharacterLvlUp();}
        #endregion








        #region Rouge Data
        public static void PrintRougeData(){Console.WriteLine(rouge);}
        public static void IncreaseRougeLvl(){rouge.CharacterLvlUp();}
        #endregion





        #region Warrior Data
        public static void PrintWarriorData(){ Console.WriteLine(warrior);}
        public static void IncreaseWarriorLvl(){ warrior.CharacterLvlUp();}
        #endregion
    }
}
