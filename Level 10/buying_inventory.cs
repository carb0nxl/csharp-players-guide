// challenge: buying inventory

/*
 * Build an inventory menu with prices.
 * ____________________________________
 * Price guide:
 * rope: 10g
 * torches: 15g
 * climbing equipment: 25g
 * clean water: 1g
 * machete: 20g
 * canoe: 200g
 * food supplies: 1g
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

Console.WriteLine($"{item} costs {price} gold.");

