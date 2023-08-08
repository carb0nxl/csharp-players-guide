// Level 16: Simula's test

// goal: use enums here 


StateOfBox boxStatus = StateOfBox.Locked;
Actions currentAction;

while (true)
{
    
    string input = ReceiveInput();
    StateMachine(ref boxStatus, input);
    
}


// ======= METHODS ===================================================================

string ReceiveInput()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("What do you want to do?: ");
    string userInput = Console.ReadLine();
    bool isValidated = InputValidator(userInput);
    while (isValidated == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\nInvalid entry. Please try again using only the following options:");
        Console.ForegroundColor = ConsoleColor.Green;            
        Console.WriteLine("open | close | lock | unlock");
        userInput = ReceiveInput();
    }
    return userInput;
}

// This method is only focused on passing input validation
// true/false
bool InputValidator(string userInput)
{
        userInput = userInput.ToLower();
        switch (userInput)
            {
                case "unlock":
                    return true;
                case "lock":
                    return true;
                case "open":
                    return true;
                case "close":
                    return true;
                default:
                    return false;
            }
}


StateOfBox StateMachine(ref StateOfBox boxCurrentState, string input)
{
    while (true)
    {
        if (boxCurrentState == StateOfBox.Locked && input == "unlock")
        {
            boxCurrentState = StateOfBox.Unlocked;
            return StateOfBox.Unlocked;
        }
        else if (boxCurrentState == StateOfBox.Unlocked && input == "lock")
        {
            boxCurrentState = StateOfBox.Locked;
            return StateOfBox.Locked;
        }
        else if (boxCurrentState == StateOfBox.Unlocked && input == "open")
        {
            boxCurrentState = StateOfBox.Open;
            return StateOfBox.Open;
        }
        else if (boxCurrentState == StateOfBox.Open && input == "close")
        {
            boxCurrentState = StateOfBox.Closed;
            return StateOfBox.Closed;
        }
        else if (boxCurrentState == StateOfBox.Closed && input == "lock")
        {
            boxCurrentState = StateOfBox.Locked;
            return StateOfBox.Locked;
        }
        else if (boxCurrentState == StateOfBox.Closed && input == "unlock")
        {
            boxCurrentState = StateOfBox.Unlocked;
            return StateOfBox.Unlocked;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"You can't do that! ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Try again... ");
            input = ReceiveInput(); // Ask for new input
        } 
    } 
}




enum StateOfBox
{
    Locked,
    Unlocked,
    Open,
    Closed
};

enum Actions
{
    Lock,
    Unlock,
    Open,
    Close
};


// Console.ForegroundColor = ConsoleColor.Red;
// Console.Write("\nInvalid entry. Please try again using only the following options:");
// Console.ForegroundColor = ConsoleColor.Green;            
// Console.WriteLine("open | close | lock | unlock");
// Console.ForegroundColor = ConsoleColor.White;
// Console.Write("What would you like to do?");