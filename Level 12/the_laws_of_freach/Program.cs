// level 12: challenge: the laws of Freach


int[] arrayA = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = int.MaxValue; // Start higher than anything in the array. 

foreach(int value in arrayA)
{
    if (value < currentMinimum)
        currentMinimum = value;
}

Console.WriteLine(currentMinimum);


int[] arrayB = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

int total = 0;

foreach (var item in arrayB)
{
    total += item;
}

float average = (float)total / arrayB.Length;
Console.WriteLine(average);