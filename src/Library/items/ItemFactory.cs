namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        Sword = 3,
        Shield = 4,
        Helmet = 5,
        Armor = 6,
        Stick = 7,
        PowerGloves = 8,
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Sword: return new Sword();
                case ItemType.Shield: return new Shield();
                case ItemType.Helmet: return new Helmet();
                case ItemType.Armor: return new Armor();
                case ItemType.Stick: return new Stick();
                case ItemType.PowerGloves: return new PowerGloves();



                default: return null;
            }
        }

        public static IItem GetRandomItem()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(ItemType));
            ItemType randomItemType = (ItemType)values.GetValue(random.Next(values.Length));
            return GetItem(randomItemType);
        }

    }
}