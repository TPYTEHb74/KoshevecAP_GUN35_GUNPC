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

        
        


        public Interval(int minValue, int maxValue)   
        {
            _random = new Random();
            if (minValue >  maxValue)
            {
                Console.WriteLine("Incorrect data: MinValue > MaxValue");
                (minValue, maxValue) = (maxValue, minValue);
            }

            if (minValue < 0)
            {
                Console.WriteLine("Incorrect data: MinValue is negative");
                minValue = 0;
            }
            else
            {
                minValue = minValue;
            }

            if (maxValue > 0)
            {
                Console.WriteLine("Incorrect data: MaxValue is negative");
                minValue = 0;
            }
            else
            {
                maxValue = maxValue;
            }

            if (minValue == maxValue)
            {
                Console.WriteLine("Incorrect data: MinValue is equal to MaxValue");
                maxValue += 10;
            }   
            
            _min = minValue;
            _max = maxValue;
        }

        public int GetRandom()
        {
            return _random.Next(_min, _max + 1);
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
