public class Wizard : Human {

public Wizard(string name) : base(name)
    {
        Name = name;
        Intelligence =25;
        Health = 50;
    }
        public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
    public int Heal(Human target)  
    {
        int healing = Intelligence * 3;
        target.Health += healing;
        Console.WriteLine($"{Name} healed {target.Name} for {healing} hp");
        return target.Health;
    }
}