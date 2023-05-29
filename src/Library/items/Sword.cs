namespace RoleplayGame.Items
{
    public class Sword : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 2;
            }
        }

        public override string ToString()
        {
            return "Sword";
        }
    }
}