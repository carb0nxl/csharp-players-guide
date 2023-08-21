// challenge: watchtower 
int xCoords, yCoords;

Console.Write("Input the enemy's X coordinate: ");
xCoords = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the enemy's y coordinate: ");
yCoords = Convert.ToInt32(Console.ReadLine());

// Determine enemy coordinates relative to watchtower

// first row
if (xCoords < 0 && yCoords > 0) Console.WriteLine("The enemy is NORTHWEST from the watchtower!");
if (xCoords == 0 && yCoords > 0) Console.WriteLine("The enemy is NORTH from the watchtower!");
if (xCoords > 0 && yCoords > 0) Console.WriteLine("The enemy is NORTHEAST from the watchtower!");
// second row
if (xCoords < 0 && yCoords == 0) Console.WriteLine("The enemy is WEST from the watchtower!");
if (xCoords == 0 && yCoords == 0) Console.WriteLine("The enemy is HERE at the watchtower!!!");
if (xCoords > 0 && yCoords == 0) Console.WriteLine("The enemy is WEST from the watchtower!");
// third row
if (xCoords < 0 && yCoords < 0) Console.WriteLine("The enemy is SOUTHWEST from the watchtower!");
if (xCoords == 0 && yCoords < 0) Console.WriteLine("The enemy is SOUTH from the watchtower!!!");
if (xCoords > 0 && yCoords < 0) Console.WriteLine("The enemy is SOUTHEAST from the watchtower!");
