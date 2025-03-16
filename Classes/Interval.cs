using System.Globalization;

namespace Classes
{
   public struct Interval
    {
        private readonly int _min;
        private readonly int _max;
        private readonly Random _random;

        public int Min => _min;
        public int Max => _max;
        public int Get()
        {
            return _random.Next(_min, _max);
        }

        
        public int MinValue {  get; private set; }
        public int MaxValue { get; private set; }


        public Interval(int minValue, int maxValue)   
        {
            if (minValue >  MaxValue)
            {
                Console.WriteLine("Incorrect data: MinValue > MaxValue");
                (minValue, maxValue) = (maxValue, minValue);
            }

            if (minValue < 0)
            {
                Console.WriteLine("Incorrect data: MinValue is negative");
                MinValue = 0;
            }
            else
            {
                MinValue = minValue;
            }

            if (maxValue > 0)
            {
                Console.WriteLine("Incorrect data: MaxValue is negative");
                MinValue = 0;
            }
            else
            {
                MaxValue = maxValue;
            }

            if (MinValue == MaxValue)
            {
                Console.WriteLine("Incorrect data: MinValue is equal to MaxValue");
                MaxValue += 10;
            }           
        }
    }

    public struct Room
    {
       public Unit Unit { get; private set; }
        public Weapon Weapon { get; private set; }

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }
}
