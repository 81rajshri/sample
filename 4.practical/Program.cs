using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 25, 5, 40, 15 };

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];

            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Minimum: " + min);
    }
}