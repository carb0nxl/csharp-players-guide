// Challenge: repairing the clocktower

Console.Write("Enter your number: ");
var input = int.Parse(Console.ReadLine());
var numInput = input;

if (numInput % 2 == 0)
    Console.WriteLine("Tick");

else
    Console.WriteLine("Tock");

