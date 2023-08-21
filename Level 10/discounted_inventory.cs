// challenge: discounted inventory

/*
 * This is a continuation of the previous challenge: inventory
 *
 * This program will also ask for user's name,
 * and if that user is the programmer's name,
 * they get a 50% discount that is reflected in the response.
 */

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
int itemNumber = Convert.ToInt32(Console.ReadLine());



string item = itemNumber switch
    
{
//_itemNumber___item____________
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
    
{
//__item__________________price___
    "Rope"               => 10,
    "Torches"            => 15,
    "Climbing Equipment" => 25,
    "Clean Water"        => 1,
    "Machete"            => 20,
    "Canoe"              => 200,
    "Food Supplies"      => 1
};

Console.Write("What is your name?: ");
string name = Console.ReadLine();

// if the name matches "Channing, apply 50% discount
if (name == "Channing" || name == "channing"|| name == "chan") price /= 2;


Console.WriteLine($"{item} costs {price} gold.");

