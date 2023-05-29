namespace RoleplayGame.Items
{
    public class Helmet: IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 15;
            }
        }

        public override string ToString()
        {
            return "Helmet";
        }
    }
}