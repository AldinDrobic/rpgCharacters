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
        private string _name;
        private int _lvl = 1;
        private PrimaryAttributes _primaryAttributes;
        private double _totalAttributes;
        private Dictionary<ItemSlot, string> _equipments = new Dictionary<ItemSlot, string>();

        /// <summary>
        /// Constructor for instantiating objects
        /// </summary>
        /// <param _name="name">_name of character</param>
        /// <param _name="Strength">Characters Strength</param>
        /// <param _name="dexterity">Characters dexterity</param>
        /// <param _name="intelligence">Characters intelligence</param>
        public Character(string name, int strength, int dexterity, int intelligence)
        {
            this._name = name;
            this._primaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);
        }

        #region Getters
        /// <summary>
        /// Get character _name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return _name;
        }
        /// <summary>
        /// Get character _lvl
        /// </summary>
        /// <returns></returns>
        public int GetLvl()
        {
            return _lvl;
        }
        /// <summary>
        /// Get primary attributes
        /// </summary>
        /// <returns></returns>
        public PrimaryAttributes GetPrimaryAttributes()
        {
            return _primaryAttributes;
        }
        /// <summary>
        /// Get total attributes
        /// </summary>
        /// <returns></returns>
        public double GetTotalAttributes()
        {
            return _totalAttributes;
        }
        /// <summary>
        /// Get characters equipments
        /// </summary>
        /// <returns></returns>
        public Dictionary<ItemSlot, string> GetEquipments()
        {
            return _equipments;
        }
        #endregion

        #region Setters
        /// <summary>
        /// Set items/equipements to character
        /// </summary>
        /// <param _name="itemSlot">The slot where the item is being putted</param>
        /// <param _name="itemName">The _name of the item</param>
        public void SetEquipments(ItemSlot itemSlot, string itemName)
        {
            try
            {
                //If the item slot is already taken, don't equip the item.
                if (_equipments.Keys.Contains(itemSlot))
                {
                    throw new InvalidItemException();
                }
                else
                    _equipments.Add(itemSlot, itemName);
            }
            catch (InvalidItemException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        #endregion
        
    }
}
