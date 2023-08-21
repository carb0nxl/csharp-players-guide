ChestState status = ChestState.Locked;

while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"The chest is ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{status}.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Your options are: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("open | close | lock | unlock");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("What would you like to do?: ");
    string userAction = Console.ReadLine();

    if (status == ChestState.Locked && userAction == "unlock")
    {
        status = ChestState.Unlocked;
    }
    else if (status == ChestState.Unlocked && userAction == "open")
    {
        status = ChestState.Open;
    }
    else if (status == ChestState.Open && userAction == "close")
    {
        status = ChestState.Closed;
    }    
    else if (status == ChestState.Closed && userAction == "lock")
    {
        status = ChestState.Locked;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid answer or action, please try again.");
    }

}

enum ChestState
{
    Open, Closed, Locked, Unlocked
}