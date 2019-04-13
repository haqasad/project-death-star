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

        [Test]
        public void CalculateTotalDamage_SetTwoWeaponsInDifferentSlots_GivesSummationOfWeaponsDamagePower()
        {
            using(var mock = AutoMock.GetLoose())
            {
                // Arrange
                var raven = Battleship.CreateBattleship("Raven");
                mock.Mock<IWeapon>().Setup(x => x.KineticDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ThermalDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ElectromagneticDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.ExplosiveDamage).Returns(500);
                mock.Mock<IWeapon>().Setup(x => x.Type).Returns(WeaponType.Large);

                var cannon = mock.Create<IWeapon>();
                var cannon2 = mock.Create<IWeapon>();

                raven.InstallWeapon(cannon, 3);
                raven.InstallWeapon(cannon2, 4);

                // Act
                uint result = raven.CalculateTotalDamage();

                // Assert
                Assert.AreEqual(4000, result);
            }
        }

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}