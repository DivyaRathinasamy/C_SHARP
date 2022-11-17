 Human Tom = new Human("Tom");
Wizard Larry = new Wizard("Larry");
Human Man = new Human("Man");
Ninja Tim = new Ninja("Tim");

Samurai Jack = new Samurai("Jack");

// Console.WriteLine(Tom.Intelligence);

Console.WriteLine(Man.Attack(Tom));

Console.WriteLine(Larry.Heal(Tom));
Console.WriteLine(Man.Attack(Tom));
Console.WriteLine(Man.Attack(Tom));
Console.WriteLine(Man.Attack(Tom));
Console.WriteLine(Man.Attack(Tom));
Console.WriteLine(Man.Attack(Tom));

Console.WriteLine(Larry.Heal(Tom));

Console.WriteLine(Tim.Steal(Tom));
Console.WriteLine(Tim.Attack(Tom));
Console.WriteLine(Tim.Attack(Tom));
Console.WriteLine(Jack.Attack(Tom));

Console.WriteLine(Tim.Attack(Jack));
Console.WriteLine(Tim.Attack(Jack));

Console.WriteLine(Jack.Attack(Larry));
Console.WriteLine(Jack.Attack(Tim));