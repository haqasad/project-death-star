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
                BattleFormation formation = new BattleFormation("formation 1");
            }
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}