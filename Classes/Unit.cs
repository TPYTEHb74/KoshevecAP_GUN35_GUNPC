public class Unit
{
    private float _health;
    private float _armour;
    private float _damage;

    public string Name { get; }

    public float Health => _health;

    public float Damage => _damage;

    public Unit() : this("Unknown Unit") { }


    public Unit(string name)
    {
        Name = name;
    }

    public Unit(int damage)
    {
        int Damage = damage;
        _damage = 5;
    }

    public Unit(float armour)
    {
        float Armour = armour;
        _armour = 0.6f;
    }

    public float GetRealHealth()
    {
        return Health * (1f + Armour);
    }

    public float Armour
    {
        get { return (float)Math.Round(_armour, (int)0.6); }
    }

    public bool SetDamage()
    { 
         if (Health <= 0f)
        {
            return true; 
        }
         else if (Health >= 0f)
        {
            return false;
        }
    }
}


        
    

