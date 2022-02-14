using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models
{
    public abstract class Character
    {
        private string Name;
        private int Lvl = 1;
        private PrimaryAttributes PrimaryAttributes;
        private double TotalAttributes;
        private Dictionary<ItemSlot, string> Equipments = new Dictionary<ItemSlot, string>();

        public Character(string name, int strength, int dexterity, int intelligence)
        {
            this.Name = name;
            this.PrimaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);
        }

        #region Getters
        /// <summary>
        /// Get character name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return Name;
        }
        /// <summary>
        /// Get character lvl
        /// </summary>
        /// <returns></returns>
        public int getLvl()
        {
            return Lvl;
        }
        /// <summary>
        /// Get primary attributes
        /// </summary>
        /// <returns></returns>
        public PrimaryAttributes GetPrimaryAttributes()
        {
            return PrimaryAttributes;
        }
        /// <summary>
        /// Get total attributes
        /// </summary>
        /// <returns></returns>
        public double getTotalAttributes()
        {
            return TotalAttributes;
        }
        /// <summary>
        /// Get characters equipments
        /// </summary>
        /// <returns></returns>
        public Dictionary<ItemSlot, string> getEquipments()
        {
            foreach (var item in Equipments)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            return Equipments;
        }
        #endregion

        #region Setters
        /// <summary>
        /// Set items/equipements to character
        /// </summary>
        /// <param name="itemSlot">The slot where the item is being putted</param>
        /// <param name="itemName">The name of the item</param>
        public void setEquipments(ItemSlot itemSlot, string itemName)
        {
            try
            {
                if (Equipments.Keys.Contains(itemSlot))
                {
                    throw new InvalidItemException();

                }
                else
                    Equipments.Add(itemSlot, itemName);
            }
            catch (InvalidItemException ex)
            {

                Console.WriteLine(ex);
            }
           
        }
        #endregion
        
    }
}
