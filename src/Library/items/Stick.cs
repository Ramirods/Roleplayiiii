namespace RoleplayGame.Items
{
    public class Stick : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 40;
            }
        }

        public override string ToString()
        {
            return "Stick";
        }
    }
}