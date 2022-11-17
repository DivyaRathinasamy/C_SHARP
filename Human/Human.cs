class Human
{
    // Properties for Human
    public string Name{get;set;}
    public int Strength{get;set;}
    public int Intelligence{get;set;}
    public int Dexterity{get;set;}
    public int Health{get;set;}
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values

    public Human(string name, int strength, int intelligence, int dexterity, int health);
    {
        Name =name;
        Strength = strength;

        

    }
     
    // Add a constructor to assign custom values to all fields
     
    // Build Attack method
    public int Attack(Human target)
    {
    }
}

