public class Unit
{
    private float _health;
    
    public string Name { get; }
    public int Damage { get; } = 5;
    public float Armour { get; } = 0.6f;
    public float Health => _health;
    public Unit() : this("Unknown Unit") { }
 
    public Unit(string name)
    {
        Name = name;
    }

    public float GetRealHealth()
    {
        return Health * (1f + Armour);
    }

   public bool SetDamage(float value)
    {
        _health -= value * Armour;

        return _health <= 0f;
    }     
}


        
    

