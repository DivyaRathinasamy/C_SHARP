List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");

// Execute Assignment Tasks here!

// Use LINQ to find the first eruption that is in Chile and print the result.
// Eruption firstChile = eruptions.Where(c => c.Location == "Chile").First();
// Console.WriteLine(firstChile);

// // Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption firstHawaiianIs = eruptions.Where(h => h.Location =="Hawaiian Is").First();
Console.WriteLine(firstHawaiianIs);

// // Find the first eruption that is after the year 1900 AND in "New Zealand", then print it
Eruption firsteruption = eruptions.Where(e => e.Year > 1900).First(e => e.Location == "New Zealand");
Console.WriteLine(firsteruption);

// Find all eruptions where the volcano's elevation is over 2000m and print them.
Eruption firstelevation = eruptions.Where(e => e.ElevationInMeters > 2000).First();
Console.WriteLine(firstelevation);

// Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> zVolcanoes = eruptions.Where(y => y.Volcano.StartsWith("L"));
int count = eruptions.Count(c=> c.Volcano.StartsWith("L"));
Console.WriteLine(count + " eruption(s) found starting with L.");
PrintEach(zVolcanoes, "Volcanoes starting with L:");

// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElevation = eruptions.Max(m=> m.ElevationInMeters);
Console.WriteLine(highestElevation);

// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
IEnumerable<Eruption> elevated = eruptions.Where(elev => elev.ElevationInMeters == highestElevation);
PrintEach(elevated, "This is the tallest Eruption!");

// Print all Volcano names alphabetically.
IEnumerable<Eruption> alphabetical = eruptions.OrderBy(p => p.Volcano);
PrintEach(alphabetical);

// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> ancient = eruptions.OrderBy(p => p.Volcano).Where(y => y.Year < 1000);
PrintEach(ancient, "Eruptions before 1000CE:");


 
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
