using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using rpgCharacters.Models.Attributes;

namespace rpgCharacters.Models.Characters.Abstract
{
    public abstract class Character
    {
        #region private class variables
        private string _name;
        private int _lvl = 1;
        private Enum _characterType;
        private PrimaryAttributes _primaryAttributes;
        private int _mainAttribute;
        private double _addedArmorAttributes;
        private double _totalAttributes;
        private double _damage = 1;
        private Weapon _weapon;
        private Dictionary<ItemSlot, string> _equipments = new Dictionary<ItemSlot, string>();
        /// <summary>
        /// This is used to save attribute values for each armor that character is equipping
        /// </summary>
        private Dictionary<string, int> _armorAttributesSet = new Dictionary<string, int>()
        {
            {"HEAD", 0},
            {"BODY", 0},
            {"LEGS", 0}
        };
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

            return Math.Round(this._damage, 1);
        }
        /// <summary>
        /// Return the equipped weapon
        /// </summary>
        /// <returns></returns>
        public Weapon GetWeapon()
        {
            return this._weapon;
        }
        #endregion

        #region Setters
        /// <summary>
        /// Set armors to characters equipment list
        /// </summary>
        /// <param _name="itemSlot">The slot where the item is being putted</param>
        /// <param _name="itemName">The _name of the item</param>
        public string SetArmorIntoEquipments(Armor armor)
        {
            try
            {
                //If the item slot is already taken, don't equip the item.
                if (_equipments.Keys.Contains(armor.GetItemSlot()))
                {
                    Console.WriteLine($"You already have a {armor.GetItemSlot()} equipped, " +
                                      $"do you want to replace it? (y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        //Equip armor
                        this._equipments[armor.GetItemSlot()] = armor.GetItemName();
                        SetArmorAttributes(armor);
                        return _armorEquipped(armor.GetItemName());
                    }
                }
                else
                {
                    this._equipments.Add(armor.GetItemSlot(), armor.GetItemName());
                    SetArmorAttributes(armor);
                    return _armorEquipped(armor.GetItemName());
                }
            }
            catch (InvalidItemException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
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
        public string SetWeaponIntoEquipments(Weapon weapon)
        {
            try
            {
                //If the item slot is already taken, don't equip the item.
                if (_equipments.Keys.Contains(weapon.GetItemSlot()))
                {
                    Console.WriteLine($"You already have a {weapon.GetItemSlot()} equipped, " +
                                      $"do you want to replace it? (y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        //Equip weapon
                        _SetWeapon(weapon);
                        this._equipments[weapon.GetItemSlot()] = weapon.GetItemName();
                        SetCharacterDamage();
                        return _weaponEquipped(weapon.GetItemName());
                    }
                }

                else
                {
                    _SetWeapon(weapon);
                    this._equipments.Add(weapon.GetItemSlot(), weapon.GetItemName());
                    SetCharacterDamage();
                    return _weaponEquipped(weapon.GetItemName());
                }
            }
            catch (InvalidItemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;

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
        protected void SetMainAttribute(int mainAttribute)
        {
            this._mainAttribute = mainAttribute;
        }
        /// <summary>
        /// Set characters armor attribute which is used to increase damage
        /// </summary>
        /// <param name="armor">The armor which character has equipped</param>
        private void SetArmorAttributes(Armor armor)
        {
            this._addedArmorAttributes = 0;
            switch (armor.GetItemSlot())
            {
                case ItemSlot.HEAD:
                    _armorAttributesSet["HEAD"] = armor.GetArmorAttributes().Defence;
                    break;
                case ItemSlot.BODY:
                    _armorAttributesSet["BODY"] = armor.GetArmorAttributes().Defence;
                    break;
                case ItemSlot.LEGS:
                    _armorAttributesSet["LEGS"] = armor.GetArmorAttributes().Defence;
                    break;
            }

            // Calculate sum of all defence attributes and add it to addedArmorAttributes.
            foreach (var VARIABLE in _armorAttributesSet)
            {
                this._addedArmorAttributes += VARIABLE.Value;
            }
            SetCharacterDamage();
        }
        /// <summary>
        /// Set damage of the character
        /// </summary>
        public void SetCharacterDamage()
        {
            if (this._weapon == null)
                this._damage = 1;
            else
                this._damage = this._weapon.GetDPS() * (_addedArmorAttributes + (this._mainAttribute + (_totalAttributes / 100)));
        }
        #endregion

        #region Other methods
        /// <summary>
        /// This method will increase character lvl
        /// </summary>
        /// <param name="strength">Characters strength</param>
        /// <param name="dexterity">Characters dexterity</param>
        /// <param name="intelligence">Characters intelligence</param>
        public string CharacterLvlUp(int strength, int dexterity, int intelligence)
        {
            this._primaryAttributes.Strength += strength;
            this._primaryAttributes.Dexterity += dexterity;
            this._primaryAttributes.Intelligence += intelligence;
            this._mainAttribute = CheckForCharacterClass();
            this._lvl++;
            SetCharacterDamage();
            return $"Your character successfully leveled up from level: {this._lvl-1} to level: {this._lvl}";
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
        /// Check the character class to determine which attribute is the main attribute,
        /// eg. Mage => Intelligence
        /// </summary>
        /// <returns></returns>
        public int CheckForCharacterClass()
        {
            return _characterType switch
            {
                CharacterTypes.Mage => GetPrimaryAttributes().Intelligence,
                CharacterTypes.Ranger => GetPrimaryAttributes().Dexterity,
                CharacterTypes.Rouge => GetPrimaryAttributes().Dexterity,
                CharacterTypes.Warrior => GetPrimaryAttributes().Strength,
                _ => 0,
            };
        }
        /// <summary>
        /// Will return string with the equipped armor
        /// </summary>
        /// <param name="armorName">Name of armor</param>
        /// <returns></returns>
        private string _armorEquipped(string armorName)
        {
            return $"You successfully equipped a {armorName}";
        }
        /// <summary>
        /// Will return string with the equipped weapon
        /// </summary>
        /// <param name="weaponName">Name of weapon</param>
        /// <returns></returns>
        private string _weaponEquipped(string weaponName)
        {
            return $"You successfully equipped a {weaponName}";
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
                   $"Damage: {Math.Round(this._damage, 1)}\n";
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
