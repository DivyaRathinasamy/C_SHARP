// name = "Tim"
// age = 30
// height = 1.905
// blueEyed = false

// string name = "Todd";
// int age = 32;
// double height = 1.875;
// bool blueEyed = true;

//Declare a variable called rings that is of the Int Type
// int numRings = 5;
// if (numRings >= 5)
// {
//     Console.WriteLine("You are welcome to join the party");
// }
// else
// {
//     Console.WriteLine("Go win some more rings");
// }

// If we have more than one condition we can add an else if statement:

// int numRings = 5;
// if (numRings >= 5)
// {
//     Console.WriteLine("You are welcome to join the party");
// }
// else if (numRings > 2)
// {
//     Console.WriteLine($"Decent...but {numRings} rings aren't enough");
// }
// else
// {
//     Console.WriteLine("Go win some more rings");
// }

// int numRings = 5;
// string name = "Kobe";
// if (numRings >= 5 && name == "Kobe")
// {
//   Console.WriteLine($"Welcome to the party {name}, congratulations on your {numRings} championships!");
// }

// We can change our criteria and say that you have to have at least 5 rings or more than 3 All-Star appearances.

// int numRings = 5;
// int numOfAllStarAppearances = 17;
// if (numRings >= 5 || numOfAllStarAppearances > 3)
// {
//   Console.WriteLine("Welcome, you are truly a legend");
// }

// Or we can just let in everyone who is not crazy.

// bool crazy = true;
// if (!crazy)
// {
//     Console.WriteLine("Let's party!");
// }

//  FOORLOOP==========================================================================
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

// To generate 10 random values between 2 and 8 (2 inclusive, 8 exclusive), we can call .Next(2,8) in a for loop:

// Random rand = new Random();
// for(int val = 0; val < 10; val++)
// {
//     //Prints the next random value between 2 and 8
//     Console.WriteLine(rand.Next(2,8));
// }

// ARRAYS===============================================================================================
// // Declaring an array of length 5, initialized by default to all zeroes
// int[] numArray = new int[5];
// // Declaring an array with pre-populated values
// // For Arrays initialized this way, the length is determined by the size of the given data
// int[] numArray2 = {1,2,3,4,6};

// int[] arr = {1, 2, 3, 4};
// Console.WriteLine($"The first number of the arr is {arr[0]}"); 
// arr[0] = 8;
// Console.WriteLine($"The first number of the arr is now {arr[0]}");
// // The array has now changed!

// ITERATING THROUGH AN ARRAY==========================================================================

// string[] myCars = new String[] {"Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};

// for(int i= 0; i<myCars.Length; i++);
// {
//     Console.WriteLine("This is my {myCars[i]}");
// }


// string[] myCars = new String[] {"Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
// foreach(string car in myCars);
// {
//     Console.WriteLine("This is my {cars}");
// }


// // //Initializing an empty list of Motorcycle Manufacturers
// List<string> bikes = new List<string>();
// //Use the Add function in a similar fashion to push
// bikes.Add("Kawasaki");
// bikes.Add("Triumph");
// bikes.Add("BMW");
// bikes.Add("Moto Guzzi");
// bikes.Add("Harley Davidson");
// bikes.Add("Suzuki");
// //Accessing a generic list value is the same as you would an array
// Console.WriteLine(bikes[2]); //Prints "BMW"
// Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

// // ITERATING THROUGH A LIST============================================================================

// //Using our list of motorcycle manufacturers from before
// //we can easily loop through the list of them with a C-style for loop
// //this time, however, Count is the attribute for a number of items.
// Console.WriteLine("The current manufacturers we have seen are:");
// for (var idx = 0; idx < bikes.Count; idx++)
// {
//     Console.WriteLine("-" + bikes[idx]);
// }
// // Insert a new item between a specific index
// bikes.Insert(2, "Yamaha");
// //Removal from Generic List
// //Remove is a lot like Javascript array pop, but searches for a specified value
// //In this case we are removing all manufacturers located in Japan
// bikes.Remove("Suzuki");
// bikes.Remove("Yamaha");
// bikes.RemoveAt(0); //RemoveAt has no return value however
// //The updated list can then be iterated through using a foreach loop
// Console.WriteLine("List of Non-Japanese Manufacturers:");
// foreach (string manu in bikes)
// {
//     Console.WriteLine("-" + manu);
// }

// // DICTIONARY CLASS=============================================================
// Dictionary<string,string> profile = new Dictionary<string,string>();
// //Almost all the methods that exists with Lists are the same with Dictionaries
// profile.Add("Name", "Speros");
// profile.Add("Language", "PHP");
// profile.Add("Location", "Greece");
// Console.WriteLine("Instructor Profile");
// Console.WriteLine("Name - " + profile["Name"]);
// Console.WriteLine("From - " + profile["Location"]);
// Console.WriteLine("Favorite Language - " + profile["Language"]);

// foreach (KeyValuePair<string,string> entry in profile)
// {
//     Console.WriteLine(entry.Key + " - " + entry.Value);
// }