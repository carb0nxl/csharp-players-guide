// this is a practice on switch statements 

// switch statement

Console.WriteLine("OPTIONS:");
Console.WriteLine("1 - Sunday");
Console.WriteLine("2 - Monday");
Console.WriteLine("3 - Tuesday");
Console.WriteLine("4 - Wednesday");
Console.WriteLine("5 - Thursday");
Console.WriteLine("6 - Friday");
Console.WriteLine("7 - Saturday");

Console.Write("Pick your favorite day [number]: ");
int menuChoice = Convert.ToInt32(Console.ReadLine());


string chosenDay = menuChoice switch
{
    1 => "Sunday",
    2 => "Monday",
    3 => "Tuesday",
    4 => "Wednesday",
    5 => "Thursday",
    6 => "Friday",
    7 => "Saturday"
};

string dayNumberOfWeek = chosenDay switch
{
    "Sunday" => "1st",
    "Monday" => "2nd",
    "Tuesday" => "3rd",
    "Wednesday" => "4th",
    "Thursday" => "5th",
    "Friday" => "6th",
    "Saturday" => "7th"
};

Console.WriteLine($"Your favorite day is {chosenDay}, which is the " +
                  $"{dayNumberOfWeek} day of the week.");
    

