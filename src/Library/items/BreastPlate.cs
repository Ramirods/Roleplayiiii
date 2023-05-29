namespace RoleplayGame.Items
{
    public class BreastPlate:IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 25;
            }
        }

        public override string ToString()
        {
            return "BreastPlate";
        }
    }
}