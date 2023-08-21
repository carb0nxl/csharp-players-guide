// challenge: the magic cannon

// for every third crank, the fire gem activates
// for every fifth crank, the electric gem activates
// every time they both line up, super blast activates

int crank = 0;

while (crank <= 100)
{
    crank++;

    {
        if (crank % 3 == 0 && crank % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{crank}# - Super attack!");
        }
        
        else if (crank % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{crank}# - Electric");
        }
        
        else if (crank %3 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{crank}# - Fire");
        }
        
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{crank}# - Normal");

        };
    }
}
