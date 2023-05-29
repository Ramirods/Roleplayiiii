using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    public class Pirate: Character
    {
        public Pirate(string name)
            : base(name)
        {
            this.Health = 110;
        }
    }
}