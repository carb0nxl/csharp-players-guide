// Level 14: Boss battle
// Hunting the Manticore

int turnNumber = 1;

// MANTICORE HP PARAMETERS
int manticoreHP = 10;

// CONSOLAS HP PARAMETERS
int consolasHP = 15;

// This will prompt Player 1 to input a distance AND assign it to a new INT 'range'
int range = DistanceManticore();

Console.Clear();
Console.WriteLine("*************************************************************************************");
Console.WriteLine("Player 2, it is your turn to find and defeat the MANTICORE.");
Console.WriteLine("The MANTICORE will continue to deal 1 damage to Consolas each turn until destroyed.");
Console.WriteLine("*************************************************************************************");

while (consolasHP > 0 && manticoreHP > 0)
{
    Status(turnNumber, manticoreHP, consolasHP);
    int damageThisRound = DamageEstimator(turnNumber);
    
    int guess = Player2Guess();
    
        if (guess > range)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("That round OVERSHOT the target.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (guess < range)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("That round FELL SHORT of the target.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (guess == range)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("That round was a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("DIRECT HIT!\n");
            Console.ForegroundColor = ConsoleColor.White;
            manticoreHP -= DamageEstimator(turnNumber);
        }
        else break;

    consolasHP--;
    turnNumber++;
}


Console.WriteLine($"The MANTICORE has been destroyed!\n" +
                  $"The city of CONSOLAS has been saved with {consolasHP} HP left!");


int Player2Guess()
{
    Console.Write("Enter desired cannon range: ");
    int guess = Convert.ToInt32(Console.ReadLine());
    return guess;
}


int DistanceManticore()
{
    int distance;
    Console.WriteLine("Player 1, the MANTICORE can be stationed any distance between 1 to 100.");
    while (true)
    {
        Console.Write("How far away do you want to station the manticore?: ");
        distance = Convert.ToInt32(Console.ReadLine());
        if (distance <= 100 && distance >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please try again with a valid distance: ");
        }
    }
    return distance;
}

int DamageEstimator(int turns)
{
    if (turns % 3 == 0 && turns % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The cannon is expected to deal 10 points of damage this round!");
        Console.ForegroundColor = ConsoleColor.White;
        return 10;
    }
        
    else if (turns % 5 == 0 || turns % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("The cannon is expected to deal 3 points of damage this round.");
        Console.ForegroundColor = ConsoleColor.White;
        return 3;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("The cannon is expected to deal 1 point of damage this round.");
        Console.ForegroundColor = ConsoleColor.White;
        return 1;
    }
}

void Status(int ROUND, int MANTICORE_HP, int CONSOLAS_HP)
{
    int MANTICORE_startingHP = MANTICORE_HP;
    int CONSOLAS_startingHP = CONSOLAS_HP;
    
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine($"Round: {ROUND} | City HP: {CONSOLAS_HP}/{CONSOLAS_startingHP} | Manticore HP: {MANTICORE_HP}/{MANTICORE_startingHP}");
}