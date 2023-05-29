using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    public class Witch: Character
    {
        public Witch(string name)
            : base(name)
        {
            this.Health = 70;
            this.AddItem(new Magic());
        }
    }
}