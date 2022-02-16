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
    }
}
