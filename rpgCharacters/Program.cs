using rpgCharacters.Models;
using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;

namespace rpgCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Weapon weapon = new Weapon("Axe", 1, ItemSlot.WEAPON, Models.Items.WeaponTypes.AXE);

            Console.WriteLine(WeaponTypes.AXE);

            string num = WeaponTypes.AXE.ToString();

            if (WeaponTypes.DAGGER.ToString() == "DAGGER")
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
