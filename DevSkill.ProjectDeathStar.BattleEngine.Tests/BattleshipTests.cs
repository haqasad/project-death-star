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

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}