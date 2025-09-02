// See https://aka.ms/new-console-template for more information
//using System;
//using System.IO;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string fileName = "favorites.txt";
//        string[] colors = new string[5];

//        Console.WriteLine("Enter your 5 favorite colors:");

//        for (int i = 0; i < colors.Length; i++)
//        {
//            Console.Write("Color " + (i + 1) + ": ");
//            colors[i] = Console.ReadLine();
//        }

//        // Write colors to the file
//        File.WriteAllLines(fileName, colors);

//        // Read and display colors
//        Console.WriteLine("\nYour favorite colors are:");
//        string[] readColors = File.ReadAllLines(fileName);
//        foreach (string color in readColors)
//        {
//            Console.WriteLine(color);
//        }
//    }
//}


using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting download...");
        await SimulateDownloadAsync();
    }

    static async Task SimulateDownloadAsync()
    {
        await Task.Delay(5000); // Wait for 5 seconds
        Console.WriteLine("Download complete!");
    }
}


