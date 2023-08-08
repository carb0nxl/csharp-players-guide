// Level 7: The Triangle Farmer

// Write a program that takes user input for a triangle's base size
// and computes the area of the triangle.

Console.WriteLine("Triangle area calculator MK1");

// Prompt user for the base and parse it as a double value instead of a string
Console.Write("\nInput the base of the triangle: ");
var triangleBase = double.Parse(Console.ReadLine());

// Prompt user for the height
Console.Write("\nInput the height of the triangle: ");
var triangleHeight = double.Parse(Console.ReadLine());

// Calculate the area
var triangleArea = (triangleBase * triangleHeight) / 2;

Console.WriteLine("The total area of your triangle is: " + triangleArea);