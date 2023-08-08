// challenge: the prototype

// ask first user to input a specific number between 0 - 100

// CHANNING'S ORIGINAL ATTEMPT
// Console.Write("PLAYER ONE: Input a number for P2 to guess: ");
// int initialNumber = Convert.ToInt32(Console.ReadLine());
//
// while (true)
// {
//     Console.Write("Player TWO: guess the number P1 entered: ");
//     int guessedNumber = Convert.ToInt32(Console.ReadLine());
//     
//     if (guessedNumber == initialNumber)
//     {   
//         Console.WriteLine("Congrats, you guessed correctly!");
//         break;
//     }
//
//     if (guessedNumber < initialNumber)
//     {
//         Console.WriteLine("You guessed too low.");
//         continue;
//     }
//
//     if (guessedNumber > initialNumber)
//     {
//         Console.WriteLine("You guessed too high.");
//         continue;
//     }
// }

// THE SOLUTION FROM TEXTBOOK
int number;

// we use a DO.WHILE loop so we can check player input before evaluation
do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());
}
// this is a tricky part:
// because a "while" being TRUE would mean running the loop again,
// you want it to be FALSE, which is why it moves on if the input
// is within the range of 0 and 100.
while (number < 0 || number > 100);

// clear the screen so user 2 does not see the answer
Console.Clear();

Console.WriteLine("User 2, guess the number.");

while(true)
{
    Console.Write("What is your next guess? ");
    int guess = Convert.ToInt32(Console.ReadLine());
    
    // if the guess > number, too high
    if (guess > number) Console.WriteLine($"{guess} is too high.");
    // if the guess < number, too low
    else if (guess < number) Console.WriteLine($"{guess} is too low.");
    // if it neither, then it can only be correct, exit loop to conclude.
    else break;
}
// Only by getting the right answer, you arrive at this message
Console.WriteLine("You guessed the number!");