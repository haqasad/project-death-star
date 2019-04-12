using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    public class Weapon : IWeapon
    {
        public string Name { get; private set; }
        public string PictureUrl { get; private set; }
        public uint KineticDamage { get; private set; }
        public uint ThermalDamage { get; private set; }
        public uint ExplosiveDamage { get; private set; }
        public uint ElectromagneticDamage { get; private set; }
        public WeaponType Type { get; private set; }

        private Weapon(string name, string pictureUrl, uint kineticDamage, 
            uint thermalDamage, uint explosiveDamage, uint electromagneticDamage, WeaponType type)
        {
            Type = type;
        }

        public static Weapon CreateWeapon(string name, WeaponType type)
        {
            switch (name)
            {
                case "Cannon":
                    if (type == WeaponType.Small)
                        return new Weapon(name, "", 50, 100, 200, 100, type);
                    else if (type == WeaponType.Medium)
                        return new Weapon(name, "", 1000, 2000, 1000, 3000, type);
                    else if (type == WeaponType.Large)
                        return new Weapon(name, "", 2000, 2000, 3000, 3000, type);
                    else
                        return null;
                case "Laser":
                    if (type == WeaponType.Small)
                        return new Weapon(name, "", 50, 100, 200, 100, type);
                    else if (type == WeaponType.Medium)
                        return new Weapon(name, "", 1000, 2000, 1000, 3000, type);
                    else
                        return null;
                default:
                    return null;
            }
        }
    }
}
