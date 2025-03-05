
namespace Classes;


public class Unit
{
    private float _health;
    private float _armour;
    private float _damage;



    private float _helm;
    public string Name { get; }

    public float Health => _health;

    public Unit() : this("Unknown Unit") { }


    public Unit(string name, float health)
    {
        Name = name;
        _health = health;
    }

    public float GetRealHealth()
    {
        return Health * (1f + Armour);
    }

    public float Armour
    {
        get { return (float)Math.Round(_armour, (int)0.6); }
        set
        {
            if (value >= 0 || value <= 1)
            {
                _armour = value;
            }
            else { }
        }
    }

    public bool SetDamage()
    {
        if (Health <= 0f)
        {
            return true;
            
        }
        
    }
}
     

        
    

