using System;

namespace Classes
{
    public class Weapon
    {
        private int minDamage;
        private int maxDamage;

        private void SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                Console.WriteLine($"Введены некоректные данные для оружия {Name}. Значения поменялись местами");
                (minDamage, maxDamage) = (maxDamage, minDamage);
            }

            if (minDamage < 1)
            {
                MinDamage = 1;
                Console.WriteLine($"Для оружия {Name} установленно минимальный урон в 1.");
            }
            else
            {
                MinDamage = minDamage;
            }

            if (maxDamage <= 1)
            {
                MaxDamage = 10;
            }
            else
            {
                MaxDamage = maxDamage;
            }
        }

        public string Name { get; }

        public int MinDamage
        {
            get { return minDamage; }
            private set { minDamage = value; }
        }

        public int MaxDamage
        {
            get { return maxDamage; }
            private set { maxDamage = value; }
        }

        public float Durability { get; }

        public Weapon (string name)
        {
            Name = name;
            Durability = 1.0f;
        }

        public Weapon (string name, int minDamage, int maxDamage ) : this ( name )
        {
            SetDamageParams( minDamage, maxDamage );
        }

        public int GetDamage()
        {
            return (MinDamage + MaxDamage) / 2;
        }


    }
}
