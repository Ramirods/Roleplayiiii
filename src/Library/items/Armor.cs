namespace RoleplayGame.Items
{
public class Armor: IDefenseItem
    {
        public Helmet helmet = new Helmet();
        public Robes robes = new Robes();

        public int DefensePower
        {
            get
            {
                return this.helmet.DefensePower + this.robes.DefensePower;
            }
        }    
    }
}