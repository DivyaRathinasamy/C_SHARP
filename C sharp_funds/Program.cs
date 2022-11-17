// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// int numRings = 5;
// string name = "Kobe";
// if (numRings >= 5 && name == "Kobe")
// {
//   Console.WriteLine($"Welcome to the party {name}, congratulations on your {numRings} championships!");
// }


// int numRings = 5;
// int numOfAllStarAppearances = 17;
// if (numRings >= 5 || numOfAllStarAppearances > 3)
// {
//   Console.WriteLine("Welcome, you are truly a legend");
// }

// bool crazy = true;
// if (!crazy)
// {
//     Console.WriteLine("Let's party!");
// }


// int start = 0;
// int end = 5;
// // loop from start to end including end
// for (int i = start; i <= end; i++)
// {
//     Console.WriteLine(i);
// }
// // loop from start to end excluding end
// for (int i = start; i < end; i++)
// {
//     Console.WriteLine(i);
// }

Random rand = new Random();
for(int val = 0; val < 10; val++)
{
    //Prints the next random value between 2 and 8
    Console.WriteLine(rand.Next(2,8));
}