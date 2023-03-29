// See https://aka.ms/new-console-template for more information
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // create a new stack to hold GPS data
        Stack gpsDataStack = new Stack();

        // simulate collecting GPS data (in this case, we'll just use random coordinates)
        for (int i = 0; i < 5; i++)
        {
            double lat = GenerateRandomCoordinate();
            double lon = GenerateRandomCoordinate();
            gpsDataStack.Push($"({lat}, {lon})");
        }

        // print the GPS data that was collected
        Console.WriteLine("GPS data collected:");
        foreach (object item in gpsDataStack)
        {
            Console.WriteLine(item);
        }

        // prompt the user to pop the data when they want to return
        Console.WriteLine("\nPress enter when you want to return and pop the GPS data...");
        Console.ReadLine();

        // pop the GPS data and print it to the console
        Console.WriteLine("\nGPS data popped:");
        while (gpsDataStack.Count > 0)
        {
            object poppedItem = gpsDataStack.Pop();
            Console.WriteLine(poppedItem);
        }
    }

    static double GenerateRandomCoordinate()
    {
        // generate a random coordinate between -180 and 180 degrees
        Random rand = new Random();
        double coordinate = rand.NextDouble() * 360 - 180;
        return Math.Round(coordinate, 6); // round to 6 decimal places
    }
}
