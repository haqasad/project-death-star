using Autofac.Extras.Moq;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using DevSkill.ProjectDeathStar.BattleEngine;

namespace Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class BattleshipTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InstallWeapon_SetWeaponInSlot_SetsWeaponInCorrectSlot()
        {
            using(var mock = AutoMock.GetLoose())
            {
                // Arrange
                var raven = Battleship.CreateBattleship("Raven");
                var cannon = Weapon.CreateWeapon("Cannon", WeaponType.Large);

                // Act
                raven.InstallWeapon(cannon, 3);

                // Assert
                Assert.AreEqual(cannon, raven.WeaponSlots[3]);
            }
        }

        [Test]
        public void CreateBattleship_GivenProperNameOfShip_CreatesCorrectShip()
        {
            using(var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act
                var raven = Battleship.CreateBattleship("Raven");

                // Assert
                Assert.Multiple(() =>
                {
                    Assert.AreEqual("Raven", raven.Name, "Name mismatch.");
                    Assert.AreEqual(8, raven.WeaponSlots.Length, "Weapon slot mismatch");
                });
            }
        }

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}