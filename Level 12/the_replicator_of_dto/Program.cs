// Level 12: Challenge: the replicator of T'Do

/*
 * Objectives:
 * - Make a program that creates an array of length 5
 * - Ask the user for five numbers and put them in the array
 * - Make a SECOND array of length 5
 * - Use a loop to copy the values out of the original array
 *   and into the new one
 * - Display the contents of both arrays one at a time.
 */
 Console.WriteLine("Please input five random numbers of your choosing.");
 int[] originalArray = new int[5];
 int[] copyArray = new int[5];
 
 int indexCount;

 for (indexCount = 0; indexCount < originalArray.Length; indexCount++)
 {
     Console.Write($"Array number {indexCount + 1} = ");
     originalArray[indexCount] = Convert.ToInt32(Console.ReadLine());
 }

 for (indexCount = 0; indexCount < copyArray.Length; indexCount++)
 {
     copyArray[indexCount] = originalArray[indexCount];
 }

 for (indexCount = 0; indexCount < originalArray.Length; indexCount++)
 {
     Console.WriteLine($"Original Array index #{indexCount} = {originalArray[indexCount]}");
     Console.WriteLine($"Copied Array index #{indexCount} = {copyArray[indexCount]}");
 }
 



 // Textbook solution

 // int[] original = new int[5];
 //
 // for(int item = 0; item < 5; item++)
 // {
 //     Console.Write("Enter a number: ");
 //     int number = Convert.ToInt32(Console.ReadLine());
 //     original[item] = number;
 // }
 //
 // int[] copy = new int[5];
 //
 // for (int index = 0; index < 5; index++)
 //     copy[index] = original[index];
 //
 // for (int index = 0; index < 5; index++)
 //     Console.WriteLine($"{original[index]} and {copy[index]}");