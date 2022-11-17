class Animal
{
    string Name;

    // Notice how this is like a function taking in a parameter for name
    Animal(string name)
    {
        // Notice how we used a capital "N" for our Name above, but a lower case "n" for our parameter
        // This helps us to distinguish which is which
        Name = name;
    }
}

Animal MyAnimal = new Animal("Dog");
Console.WriteLine($"I have a pet {MyAnimal.Name}!");

