﻿using rpgCharacters.Models.Exceptions;
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
        #region private class variables
        private string _name;
        private int _lvl = 1;
        private Enum _characterType;
        private PrimaryAttributes _primaryAttributes;
        private int _mainAttribute;
        private double _totalAttributes;
        private double _damage = 1;
        private Weapon _weapon;
        private Dictionary<ItemSlot, string> _equipments = new Dictionary<ItemSlot, string>();
        #endregion

        #region Constructor
        /// <summary>
        /// This constructor is used to create an empty character
        /// </summary>
        public Character()
        {
            this._name = _GetRandomName();
        }
        #endregion

        #region Getters
        /// <summary>
        /// Get character _name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this._name;
        }
        /// <summary>
        /// Get character _lvl
        /// </summary>
        /// <returns></returns>
        public int GetLvl()
        {
            return this._lvl;
        }
        /// <summary>
        /// Returns the type of the character, eg. Mage
        /// </summary>
        /// <returns></returns>
        public Enum GetCharacterType()
        {
            return this._characterType;
        }
        /// <summary>
        /// Get primary attributes
        /// </summary>
        /// <returns></returns>
        public PrimaryAttributes GetPrimaryAttributes()
        {
            return this._primaryAttributes;
        }
        /// <summary>
        /// Get total attributes
        /// </summary>
        /// <returns></returns>
        public double GetTotalAttributes()
        {
            return this._totalAttributes;
        }
        /// <summary>
        /// Get characters equipments
        /// </summary>
        /// <returns></returns>
        public Dictionary<ItemSlot, string> GetEquipments()
        {
            return this._equipments;
        }
        /// <summary>
        /// Get total damage that character can inflict
        /// </summary>
        /// <returns></returns>
        public double GetCharacterDamage()
        {
            if (this._equipments.Count <=0)
            {
                this._damage = 1;
            }
            return this._damage;
        }


        #endregion

        #region Setters
        /// <summary>
        /// Set armors to characters equipment list
        /// </summary>
        /// <param _name="itemSlot">The slot where the item is being putted</param>
        /// <param _name="itemName">The _name of the item</param>
        public void SetArmorIntoEquipments(ItemSlot itemSlot, string itemName)
        {
            try
            {
                //If the item slot is already taken, don't equip the item.
                if (_equipments.Keys.Contains(itemSlot))
                {
                    throw new InvalidItemException();
                }
                this._equipments.Add(itemSlot, itemName);
            }
            catch (InvalidItemException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        /// <summary>
        /// Set a weapon to the character
        /// </summary>
        /// <param name="weapon"></param>
        private void _SetWeapon(Weapon weapon)
        {
            this._weapon = weapon;
        }
        /// <summary>
        /// Set weapon to characters equipment list
        /// </summary>
        /// <param name="weapon">The weapon character is trying to equip</param>
        /// <param name="primaryAttribute">Value which is used for increasing characters damage</param>
        public void SetWeaponIntoEquipments(Weapon weapon, double primaryAttribute)
        {
            try
            {
                //If the item slot is already taken, don't equip the item.
                if (_equipments.Keys.Contains(weapon.GetItemSlot()))
                {
                    throw new InvalidItemException();
                }
                _SetWeapon(weapon);
                this._equipments.Add(weapon.GetItemSlot(), weapon.GetItemName());
                SetCharacterDamage();
            }
            catch (InvalidItemException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// This method will set a characters primary attributes
        /// </summary>
        /// <param name="strength">Characters strength</param>
        /// <param name="dexterity">Characters dexterity</param>
        /// <param name="intelligence">Characters intelligence</param>
        public void SetPrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            this._primaryAttributes = new PrimaryAttributes(strength, dexterity, intelligence);

            //Set total attributes
            this._totalAttributes = this._primaryAttributes.Strength + 
                                    this._primaryAttributes.Dexterity +
                                    this._primaryAttributes.Intelligence;
        }
        /// <summary>
        /// Set the type of the character, eg. Mage
        /// </summary>
        /// <param name="characterType"></param>
        public void SetCharacterType(CharacterTypes characterType)
        {
            this._characterType = characterType;
        }
        /// <summary>
        /// Set characters main attribute which is used to increase damage
        /// </summary>
        /// <param name="mainAttribute"></param>
        public void SetMainAttribute(int mainAttribute)
        {
            this._mainAttribute = mainAttribute;
        }

        /// <summary>
        /// Set damage of the character
        /// </summary>
        /// <param name="weapon">The weapon that the character has equipped</param>
        /// <param name="characterAttribute">The value that will increase damage</param>
        public void SetCharacterDamage()
        {
            if (this._weapon == null)
                this._damage = 1;
            else
                this._damage = this._weapon.GetDPS() * (this._mainAttribute + _totalAttributes / 100);
        }
        #endregion

        #region Other methods

        /// <summary>
        /// This method will increase character lvl
        /// </summary>
        /// <param name="strength">Characters strength</param>
        /// <param name="dexterity">Characters dexterity</param>
        /// <param name="intelligence">Characters intelligence</param>
        public void CharacterLvlUp(int strength, int dexterity, int intelligence)
        {
            this._primaryAttributes.Strength += strength;
            this._primaryAttributes.Dexterity += dexterity;
            this._primaryAttributes.Intelligence += intelligence;
            this._lvl++;
        }
        /// <summary>
        /// Method used to deal damage with character
        /// </summary>
        public void DealDamage()
        {
            double damage = GetCharacterDamage();
            Console.WriteLine($"You successfully dealt {damage} damage to your opponent!");
        }
        /// <summary>
        /// ToString method used for printing out objects
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {this._name}\n" +
                   $"Level: {this._lvl}\n" +
                   $"Class: {this._characterType}\n" +
                   $"Strength: {this._primaryAttributes.Strength}\n" +
                   $"Dexterity: {this._primaryAttributes.Dexterity}\n" +
                   $"Intelligence: {this._primaryAttributes.Intelligence}\n" +
                   $"Damage: {this._damage}\n";
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
            string randomName = _randomNames[rnd.Next(0, 20)];

            #endregion
            return randomName;
        }
    #endregion

    }
}