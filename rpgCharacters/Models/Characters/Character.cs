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

        /// <summary>
        /// Constructor for instantiating objects
        /// </summary>
        /// <param name="name">Name of character</param>
        /// <param name="strength">Characters strength</param>
        /// <param name="dexterity">Characters dexterity</param>
        /// <param name="intelligence">Characters intelligence</param>
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
                //If the item slot is already taken, don't equip the item.
                if (Equipments.Keys.Contains(itemSlot))
                {
                    throw new InvalidItemException();
                }
                else
                    Equipments.Add(itemSlot, itemName);
            }
            catch (InvalidItemException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        #endregion
        
    }
}
