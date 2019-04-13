using Autofac.Extras.Moq;
using DevSkill.ProjectDeathStar.BattleEngine;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class BattleFormationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SetFormationRow_ValidInput_SetsShip()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange
                BattleFormation formation = new BattleFormation("formation 1");
                var shipMock = mock.Mock<Ship>();
                var ship = shipMock.Object;

                // Act
                formation.SetFormationRow(ship, 100, 2);

                // Assert
                Assert.AreSame(formation.Rows[2].SelectedShip, ship);
            }
        }

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}