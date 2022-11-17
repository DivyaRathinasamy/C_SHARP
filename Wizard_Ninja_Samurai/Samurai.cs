public class Samurai : Human 
{

    public Samurai (string name) : base (name)
    {
        Name = name;
        Health = 200;
    }

    public override int Attack(Human target)
    {
        int dmg = Health;
        if (target.Health <= 50)
        {
        target.Health -= dmg;
        } 
        {
        if (target.Health <= 0) 
        target.Health = 0;
    }
        Console.WriteLine($"{Name} attacked {target.Name},{target.Name}'s health is now {target.Health}");

        return target.Health;
    }

    public int Meditate(Human target)
    {
        int heal = Health = 200;
        heal += Health;
        // {
        //     if (Health < Health)
        //     Health += 200;
        // }
        
        Console.WriteLine($"{Name} mediated,{Name}'s health is now {Health}");
        return Health;
    }
}