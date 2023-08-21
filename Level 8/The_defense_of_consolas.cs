/*
 * 
 */

Console.Title = "The Defense of Consolas";

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();

Console.Write("Input the target row number: ");
var targetRow = int.Parse(Console.ReadLine());

Console.Write("Input the target column number: ");
var targetColumn = int.Parse(Console.ReadLine());


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"You have chosen row {targetRow}, column {targetColumn}.");
Console.WriteLine("Deploy to:");
Console.WriteLine($"({targetRow}, {targetColumn - 1})"); // LEFT of target
Console.WriteLine($"({targetRow - 1}, {targetColumn})"); // BOTTOM of target
Console.WriteLine($"({targetRow}, {targetColumn + 1})"); // RIGHT of target
Console.WriteLine($"({targetRow + 1}, {targetColumn})"); // TOP of target

Console.Beep();
