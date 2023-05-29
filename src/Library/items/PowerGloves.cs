using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class PowerGloves : IAttackItem
    {

        public int attackPower;
        public int AttackPower
        {
            get
            {
                return attackPower;
            }
        }

        public PowerGloves()
        {
            attackPower = 40;
        }

        public void AddGem(Gem gem)
        {
            attackPower += gem.AttackPower;
        }

        public override string ToString()
        {
            return "PowerGloves";
        }
    
    }
}