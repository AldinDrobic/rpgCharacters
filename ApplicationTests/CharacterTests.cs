using System;
using System.Collections.Generic;
using System.Globalization;
using rpgCharacters.Models.Characters;
using Xunit;

namespace ApplicationTests
{
    public class CharacterTests
    {
        #region A character is level 1 when created.

        [Fact]
        public void GetLvl_CreateCharacterAtLvlOne_ShouldReturnCharactersLvl()
        {
            // Arrange
            Mage mage = new Mage();
            int expected = 1;
            // Act
            int actual = mage.GetLvl();
            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region When a character gains a level, it should be level 2.

        [Fact]
        public void CharacterLvlUp_IncreaseCharactersLvlByOne_ShouldReturnCharactersIncreasedLvl()
        {
            // Arrange
            Mage mage = new Mage();
            mage.CharacterLvlUp();
            int expected = 2;
            // Act
            int actual = mage.GetLvl();
            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Each character class is created with the proper default attributes.

        #region Mage

        [Fact]
        public void Constructor_CreateMageCharacterWithProperAttributes_ShouldReturnCharacterWithProperAttributes()
        {
            // Arrange
            Mage mage = new Mage();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Strength", 1},
                {"Dexterity", 1},
                {"Intelligence", 8}
            };

            // Act
            Dictionary<string, int> actual = new Dictionary<string, int>()
            {
                {"Strength", mage.GetPrimaryAttributes().Strength},
                {"Dexterity", mage.GetPrimaryAttributes().Dexterity},
                {"Intelligence", mage.GetPrimaryAttributes().Intelligence}
            };
            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Ranger
        [Fact]
        public void Constructor_CreateRangerCharacterWithProperAttributes_ShouldReturnCharacterWithProperAttributes()
        {
            // Arrange
            Ranger ranger = new Ranger();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Strength", 1},
                {"Dexterity", 7},
                {"Intelligence", 1}
            };

            // Act
            Dictionary<string, int> actual = new Dictionary<string, int>()
            {
                {"Strength", ranger.GetPrimaryAttributes().Strength},
                {"Dexterity", ranger.GetPrimaryAttributes().Dexterity},
                {"Intelligence", ranger.GetPrimaryAttributes().Intelligence}
            };
            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Rouge
        [Fact]
        public void Constructor_CreateRougeCharacterWithProperAttributes_ShouldReturnCharacterWithProperAttributes()
        {
            // Arrange
            Rouge rouge = new Rouge();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Strength", 2},
                {"Dexterity", 6},
                {"Intelligence", 1}
            };

            // Act
            Dictionary<string, int> actual = new Dictionary<string, int>()
            {
                {"Strength", rouge.GetPrimaryAttributes().Strength},
                {"Dexterity", rouge.GetPrimaryAttributes().Dexterity},
                {"Intelligence", rouge.GetPrimaryAttributes().Intelligence}
            };
            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Warrior
        [Fact]
        public void Constructor_CreateWarriorCharacterWithProperAttributes_ShouldReturnCharacterWithProperAttributes()
        {
            // Arrange
            Warrior warrior = new Warrior();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Strength", 5},
                {"Dexterity", 2},
                {"Intelligence", 1}
            };

            // Act
            Dictionary<string, int> actual = new Dictionary<string, int>()
            {
                {"Strength", warrior.GetPrimaryAttributes().Strength},
                {"Dexterity", warrior.GetPrimaryAttributes().Dexterity},
                {"Intelligence", warrior.GetPrimaryAttributes().Intelligence}
            };
            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #endregion

        #region Each character class has their attributes increased when leveling up.

        #region Mage
        [Fact]
        public void CharacterLvlUp_CreateMageCharacterLvlUpOnce_ShouldReturnCharacterWithProperUpdatedAttributes()
        {
            // Arrange
            Mage mage = new Mage();
            mage.CharacterLvlUp();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Strength", 2},
                {"Dexterity", 2},
                {"Intelligence", 13}
            };

            // Act
            Dictionary<string, int> actual = new Dictionary<string, int>()
            {
                {"Strength", mage.GetPrimaryAttributes().Strength},
                {"Dexterity", mage.GetPrimaryAttributes().Dexterity},
                {"Intelligence", mage.GetPrimaryAttributes().Intelligence}
            };
            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Ranger
        [Fact]
        public void CharacterLvlUp_CreateRangerCharacterLvlUpOnce_ShouldReturnCharacterWithProperUpdatedAttributes()
        {
            // Arrange
            Ranger ranger = new Ranger();
            ranger.CharacterLvlUp();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Strength", 2},
                {"Dexterity", 12},
                {"Intelligence", 2}
            };

            // Act
            Dictionary<string, int> actual = new Dictionary<string, int>()
            {
                {"Strength", ranger.GetPrimaryAttributes().Strength},
                {"Dexterity", ranger.GetPrimaryAttributes().Dexterity},
                {"Intelligence", ranger.GetPrimaryAttributes().Intelligence}
            };
            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Rouge
        [Fact]
        public void CharacterLvlUp_CreateRougeCharacterLvlUpOnce_ShouldReturnCharacterWithProperUpdatedAttributes()
        {
            // Arrange
            Rouge rouge = new Rouge();
            rouge.CharacterLvlUp();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Strength", 3},
                {"Dexterity", 10},
                {"Intelligence", 2}
            };

            // Act
            Dictionary<string, int> actual = new Dictionary<string, int>()
            {
                {"Strength", rouge.GetPrimaryAttributes().Strength},
                {"Dexterity", rouge.GetPrimaryAttributes().Dexterity},
                {"Intelligence", rouge.GetPrimaryAttributes().Intelligence}
            };
            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Warrior
        [Fact]
        public void CharacterLvlUp_CreateWarriorCharacterLvlUpOnce_ShouldReturnCharacterWithProperUpdatedAttributes()
        {
            // Arrange
            Warrior warrior = new Warrior();
            warrior.CharacterLvlUp();
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Strength", 8},
                {"Dexterity", 4},
                {"Intelligence", 2}
            };

            // Act
            Dictionary<string, int> actual = new Dictionary<string, int>()
            {
                {"Strength", warrior.GetPrimaryAttributes().Strength},
                {"Dexterity", warrior.GetPrimaryAttributes().Dexterity},
                {"Intelligence", warrior.GetPrimaryAttributes().Intelligence}
            };
            // Assert
            Assert.Equal(expected, actual);
        }


        #endregion

        #endregion
    }
}
