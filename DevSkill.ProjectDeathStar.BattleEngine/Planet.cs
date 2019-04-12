using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Planet
    {
        public string Name { get; set; }
        public BattleFormation OffensiveFormation { get; set; }
        public BattleFormation DefensiveFormation { get; set; }

        private Planet(string name)
        {
            Name = name;
        }

        public static Planet CreatePlanet(string name)
        {
            switch (name)
            {
                case "Pandora":
                    return new Planet(name);
                case "Lava":
                    return new Planet(name);
                default:
                    return null;
            }
        }
    }
}
