using Autofac.Extras.Moq;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using DevSkill.ProjectDeathStar.BattleEngine;

namespace Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class PlanetTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatePlanet_SetValidPlanetName_CreatesNewPlanet()
        {
            using(var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act
                var pandora = Planet.CreatePlanet("Pandora");

                // Assert
                Assert.AreEqual("Pandora", pandora.Name, "Name mismatch");
            }
        }

        [Test]
        public void CreatePlanet_SetInvalidPlanetName_CreatesNewPlanet()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange

                // Act
                var earth = Planet.CreatePlanet("Earth");

                // Assert
                Assert.AreEqual(null, earth.Name, "Null mismatch");
            }
        }

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}