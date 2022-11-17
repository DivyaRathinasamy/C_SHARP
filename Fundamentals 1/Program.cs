// Create a Loop that prints all values from 1-255

// for (int i=1; i<=255;i++)
// {
//      Console.WriteLine(i);
// }

// Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both

for (var i = 1; i <= 100; i++)
{
    bool byThreeOrFive = (i % 3 == 0 || i % 5 == 0);
    bool notThreeAndFive = !(i % 3 == 0 && i % 5 == 0);

    if (byThreeOrFive && notThreeAndFive)
    {
        Console.WriteLine(i);
    }
}



// Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5

for (var i = 1; i <= 100; i++)
{
    bool byThree = (i % 3 == 0);
    bool byFive = (i % 5 == 0);
    bool byBoth = (i % 3 == 0 && i % 5 == 0 );

    if (byThree)
    {
        Console.WriteLine("Fizz");
    }
    else if (byFive)
    {
        Console.WriteLine("Buzz");
    }
    if (byBoth)
    {
        Console.WriteLine("FizzBuzz");
    }


}