
// For each time 'a' is at 1, b is incremented all the way to max
// the 'b' FOR LOOP needs to complete all runs before
// returning to the next FOR LOOP cycle in 'a' 

for(int a = 1; a <= 10; a++)
    for(int b = 1; b <= 10; b++)
        Console.WriteLine($"{a} * {b} = {a * b}");

int totalRows = 5;
int totalColumns = 10;

for (int currentRow = 1; currentRow <= totalRows; currentRow++)
{
    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
    {
        Console.Write("*");
    }
    
    Console.WriteLine();
}
