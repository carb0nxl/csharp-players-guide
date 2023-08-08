/*
 * Three kings, Melik, Casik, and Balik, are sitting around a table,
 * debating who has the greatest kingdom among them.
 * Each king rules an assortment of provinces, duchies, and estates.
 *
 * Every estate is worth 1 point.
 * Every duchy is worth 3 points.
 * Every province is worth 6 points.
 *
 * - Create a program that allows users to enter how many provinces, duchies, and estates they have.
 * - Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
 * - Display the point total to user.
 */



 Console.Write("How many estates do you have: ");
 var totalEstates = int.Parse(Console.ReadLine());
 
 Console.Write("How many duchies do you have: ");
 var totalDuchies = int.Parse(Console.ReadLine());
 
 Console.Write("How many provinces do you have: ");
 var totalProvinces = int.Parse(Console.ReadLine());
 
totalEstates *= 1;
totalDuchies *= 3;
totalProvinces *= 6;

int totalScore = totalEstates + totalDuchies + totalProvinces;

Console.WriteLine("You have a total score of: " + totalScore);