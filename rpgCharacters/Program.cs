using rpgCharacters.Models;
using rpgCharacters.Models.Characters;
using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using rpgCharacters.TestData;
using rpgCharacters.TestData.TestItems;
using System;
using System.Collections.Generic;
using rpgCharacters.TestData.TestCharacters;

namespace rpgCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestDataCharacters.MageData();
            TestDataCharacters.RangerData();
            TestDataCharacters.RougeData();
            TestDataCharacters.WarriorData();


        }
    }
}
