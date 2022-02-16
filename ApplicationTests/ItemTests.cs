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
            Mage mage = new Mage();
            Ranger ranger = new Ranger();
            Rouge rouge = new Rouge();
            Weapon axe = new Weapon("Axe", 2, ItemSlot.WEAPON, WeaponTypes.DAGGER, new WeaponAttributes(1, 1));
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => rouge.EquipWeapon(axe));
        }
        #endregion

        #region If a character tries to equip a high level armor piece, InvalidArmorException should be thrown.

        [Fact]
        public void EquipArmor_EquipHighLvlArmor_ShouldReturnInvalidArmorException()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Mage mage = new Mage();
            Ranger ranger = new Ranger();
            Rouge rouge = new Rouge();
            Armor armor = new Armor("Plate armor", 2, ItemSlot.BODY, ArmorType.LEATHER, new ArmorAttributes(1));
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => rouge.EquipArmor(armor));
        }

        #endregion
    }
}
