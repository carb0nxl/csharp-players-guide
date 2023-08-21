// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // prompt player to input subject matter -> string a
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // prompt the description from player, -> string b
string c = " of doom"; 
string d = "3000";


/*
 * Output: "The [string b: description] [string a: subject] of doom 3000!"
 */
Console.WriteLine("The " + b + " " + a + c + " " + d + "!");