using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    
    public enum AttackItemType
    {
       Magic = 1,
       Sword = 2,
       Stick = 3,
       PowerGloves = 4,
    }

    public enum DefenseItemType
    {
        Robes = 1,
        Shield = 2,
        Breastplate = 3,
        Helmet = 4,
        Armor = 5,
    }

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
                case ItemType.Shield: return new Shield();
                case ItemType.Sword: return new Sword();
                case ItemType.PowerGloves: return new PowerGloves();
                case ItemType.Helmet: return new Helmet();
                case ItemType.Stick: return new Stick();
                case ItemType.Armor: return new Armor();


                default: return null;
            }
        }

        public static IAttackItem GetAttackItem(AttackItemType type)
        {
            switch (type)
            {
                case AttackItemType.Magic: return new Magic();
                case AttackItemType.Sword: return new Sword();
                case AttackItemType.PowerGloves: return new PowerGloves();
                case AttackItemType.Stick: return new Stick();

                default: return null;
            }
        }

        public static IDefenseItem GetDefenseItem(DefenseItemType type)
        {
            switch (type)
            {
                case DefenseItemType.Robes: return new Robes();
                case DefenseItemType.Shield: return new Shield();
                case DefenseItemType.Armor: return new Armor();
                case DefenseItemType.Helmet: return new Helmet();

                default: return null;
            }
        }

        public static IItem GetRandomItem(List<IItem> items)
        {
            if (items.Count >= 1)
            {
                if (items[0] is IDefenseItem)
                {
                    Random random = new Random();
                    Array values = Enum.GetValues(typeof(AttackItemType));
                    AttackItemType randomItemType = (AttackItemType)values.GetValue(random.Next(values.Length));
                    return GetAttackItem(randomItemType);
                }
                else
                {
                    Random random = new Random();
                    Array values = Enum.GetValues(typeof(DefenseItemType));
                    DefenseItemType randomItemType = (DefenseItemType)values.GetValue(random.Next(values.Length));
                    return GetDefenseItem(randomItemType);
                }
            }
            else
            {
                Random random = new Random();
                Array values = Enum.GetValues(typeof(ItemType));
                ItemType randomItemType = (ItemType)values.GetValue(random.Next(values.Length));
                return GetItem(randomItemType);
            }
        }
    }
}