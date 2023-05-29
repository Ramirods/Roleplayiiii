using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    public class Troll: Character
    {
        public Troll(string name)
            : base(name)
        {
            this.Health = 100;
            this.AddItem(new Stick());
            this.AddItem(new BreastPlate());
        }
    }
}