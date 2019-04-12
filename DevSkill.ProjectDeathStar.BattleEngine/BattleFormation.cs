using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class BattleFormation
    {
        public string Name { get; set; }
        public FormationRow[] Rows { get; private set; }
        public bool IsActive { get; private set; }
        public General GeneralInCharge { get; private set; }
    }
}
