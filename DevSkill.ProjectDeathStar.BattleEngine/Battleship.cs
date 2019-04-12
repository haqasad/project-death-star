using System;
using System.Collections.Generic;
using System.Text;

namespace DevSkill.ProjectDeathStar.BattleEngine
{
    class Battleship : Ship
    {
        private Battleship(string name, string pictureUrl, uint sheild, uint armor, 
            uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenseSlot)
        {
            Name = name;
            WeaponSlots = new IWeapon[weaponSlot];
        }

        public void InstallWeapon(IWeapon weapon, uint slot)
        {
            if (weapon.Type == WeaponType.Large)
            {
                if (slot < WeaponSlots.Length)
                {
                    WeaponSlots[slot] = weapon;
                }
                else
                    throw new Exception("Invalid Slot");
            }
            else
                throw new Exception("Invalid Weapon");
        }

        public void RemoveWeapon(int slot)
        {
            if (slot >= 0 && slot < WeaponSlots.Length)
            {
                WeaponSlots[slot] = null;
            }
        }

        public static Battleship CreateBattleship(string shipName)
        {
            switch (shipName)
            {
                case "Raven":
                    return new Battleship(shipName, "", 1000, 2000, 1000, 3, 8, 6, 5);
                case "Dominix":
                    return new Battleship(shipName, "", 1100, 2200, 800, 3, 7, 7, 6);
                default:
                    throw new Exception("Invalid ship name");
            }
        }
    }
}
