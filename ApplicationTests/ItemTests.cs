using System;
using System.Collections.Generic;
using System.Globalization;
using rpgCharacters.Models;
using rpgCharacters.Models.Attributes;
using rpgCharacters.Models.Characters;
using rpgCharacters.Models.Exceptions;
using rpgCharacters.Models.Items;
using Xunit;

namespace ApplicationTests
{
    public class ItemTests
    {
        #region If a character tries to equip a high level weapon, InvalidWeaponException should be thrown
        [Fact]
        public void EquipWeapon_EquipHighLvlWeapon_ShouldReturnInvalidWeaponException()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Weapon axe = new Weapon("Axe", 2, ItemSlot.WEAPON, WeaponTypes.AXE, new WeaponAttributes(1, 1));
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipWeapon(axe));
        }
        #endregion

        #region If a character tries to equip a high level armor piece, InvalidArmorException should be thrown.
        [Fact]
        public void EquipArmor_EquipHighLvlArmor_ShouldReturnInvalidArmorException()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Armor armor = new Armor("Plate armor", 2, ItemSlot.BODY, ArmorType.PLATE, new ArmorAttributes(1));
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipArmor(armor));
        }
        #endregion

        #region If a character tries to equip the wrong armor type, InvalidArmorException should be thrown.
        [Fact]
        public void EquipArmor_EquipWrongArmor_ShouldReturnInvalidArmorException()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Armor armor = new Armor("Cloth armor", 2, ItemSlot.BODY, ArmorType.CLOTH, new ArmorAttributes(1));
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipArmor(armor));
        }
        #endregion

        #region If a character equips a valid weapon, a success message should be returned
        [Fact]
        public void EquipWeapon_EquipCorrectWeapon_ShouldReturnSuccessString()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Weapon sword = new Weapon("Sword", 1, ItemSlot.WEAPON, WeaponTypes.SWORD, new WeaponAttributes(1, 1));
            string expected = "You successfully equipped a Sword";            
            // Act 
            string actual = warrior.EquipWeapon(sword);

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region MyRegion
        [Fact]
        public void EquipArmor_EquipCorrectArmor_ShouldReturnSuccessString()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Armor armor = new Armor("Plate armor", 1, ItemSlot.BODY, ArmorType.PLATE, new ArmorAttributes(1));
            string expected = "You successfully equipped a Plate armor";
            // Act 
            string actual = warrior.EquipArmor(armor);

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Calculate Damage if no weapon is equipped.
        [Fact]
        public void GetCharacterDamage_CalculateDamageIfNoWeaponIsEquipped_ShouldReturnDouble()
        {
            // Arrange
            Warrior warrior = new Warrior();
            double expected = 1;
            // Act 
            double actual = warrior.GetCharacterDamage();

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Calculate Damage with valid weapon equipped.
        [Fact]
        public void GetCharacterDamage_CalculateDamageIfWeaponIsEquipped_ShouldReturnDouble()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Weapon axe = new Weapon("Axe", 1, ItemSlot.WEAPON, WeaponTypes.AXE, new WeaponAttributes(7, 1.1));
            warrior.EquipWeapon(axe);
            double expected = 39.1;

            // Act 
            double actual = warrior.GetCharacterDamage();

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Calculate Damage with valid weapon and armor equipped.
        [Fact]
        public void GetCharacterDamage_CalculateDamageIfWeaponAndArmorIsEquipped_ShouldReturnDouble()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Weapon axe = new Weapon("Axe", 1, ItemSlot.WEAPON, WeaponTypes.AXE, new WeaponAttributes(7, 1.1));
            Armor armor = new Armor("Plate armor", 1, ItemSlot.BODY, ArmorType.PLATE, new ArmorAttributes(1));
            warrior.EquipWeapon(axe);
            warrior.EquipArmor(armor);
            double expected = 46.8;

            // Act 
            double actual = warrior.GetCharacterDamage();

            // Assert
            Assert.Equal(expected, actual);
        }


        #endregion

    }
}
