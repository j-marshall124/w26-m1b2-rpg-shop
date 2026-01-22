// Step 1: Ask player for name (and remember it)
Console.WriteLine("Hello traveller! What is your name?");
string playerName = Console.ReadLine()!;

// Step 2: Ask player for sum of held gold (currency)
Console.WriteLine("How much gold do you have in your bag?");
string heldGold = Console.ReadLine()!;


// Step 3+: Tell player about sword, do that wish to purchase?
Console.WriteLine("I have a 'bronze sword' for sale for 15 gold coins.");
Console.WriteLine("Do you wish to purchase it?");
string doPurchaseSword = Console.ReadLine()!;
if (doPurchaseSword == "yes")
{
    // 3a buy sword
    if (heldGold >= 15)
    {
        // deduct cost
        // inform player of remaining gold
    }
    else
    {
        Console.WriteLine("I'm sorry, you don't have enough gold.");
    }

}
else
{
    // Console.WriteLine("Farwell on your travels, " + playerName + "."); // old version
    Console.WriteLine($"Farwell on your travels, {playerName}."); // use this in assignment "$"
}