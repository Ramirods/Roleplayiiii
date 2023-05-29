using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    public class Minotaur: Character
    {
        public Minotaur(string name)
            : base(name)
        {
            this.Health = 200;
        }
    }
}