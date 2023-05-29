using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class Gem : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 70;
            }
        }

        public override string ToString()
        {
            return "Gem";
        }
    }
}