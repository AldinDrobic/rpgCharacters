using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Characters
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
        /// <param name="strength">Characters strength</param>
        /// <param name="dexterity">Characters dexterity</param>
        /// <param name="intelligence">Characters intelligence</param>
        public Character(int strength, int dexterity, int intelligence)
        {
            this._name = _GetRandomName();
            this._primaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);
        }
        /// <summary>
        /// Constructor for instantiating objects
        /// </summary>
        /// <param _name="name">_name of character</param>
        /// <param _name="Strength">Characters strength</param>
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

        #region Random Names

        private string _GetRandomName()
        {
            #region Create list of random names

            List<string> _randomNames = new List<string>()
            {
                "Mnementh Beiroris",
                "Haldir Ertris",
                "Huethea Mirabalar",
                "Gormar Genwynn",
                "Nyvorlas Bryneiros",
                "Drannor Keazeiros",
                "Volodar Inagella",
                "Rathal Elaran",
                "Hagred Qixalim",
                "Drannor Zyljor",
                "Hagluin Yllaphine",
                "Inchel Trawynn",
                "Paeris Virhana",
                "Katyr Dorbella",
                "Malon Farzumin",
                "Liluth Jorieth",
                "Ettrian Liabella",
                "Shyrrik Wysahice",
                "Amra Loraxisys",
                "Sakaala Lorana"

            };
            Random rnd = new Random();
            string randomName = _randomNames[rnd.Next(0, 21)];

            #endregion
            return randomName;
        }
    #endregion

}
}
