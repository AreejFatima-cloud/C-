// Q: Store and iterate through sequences of data using Arrays and the foreach statement in C#
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//Q: Implement the foreach statement
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Create and initialize an array of int
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

//Q: Create a variable to hold the current bin number and display the running total
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

//Q: Complete a challenge activity for nested iteration and selection statements
string[] fraudulentOrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(string fraudul in fraudulentOrderIDs)
{
    // Console.WriteLine(fraudul);
    if (fraudul.StartsWith("B"))
        {
            Console.WriteLine(fraudul);
        }
}
