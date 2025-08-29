// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<List<int>> meterReadingsWeek = new List<List<int>>
        {
            new List<int> { 10, 15, 20 }, 
            new List<int> { 11, 16, 21 }, 
            new List<int> { 12, 17, 22 }, 
            new List<int> { 13, 18, 23 }, 
            new List<int> { 14, 19, 24 }, 
            new List<int> { 15, 20, 25 },  
            new List<int> { 16, 21, 26 }  
        };

        Dictionary<string, Dictionary<string, List<int>>> areaData =
            new Dictionary<string, Dictionary<string, List<int>>>
        {
            { "Area1", new Dictionary<string, List<int>>
                {
                    { "House1", new List<int> { 100, 101, 102, 103, 104, 105, 106 } },
                    { "House2", new List<int> { 200, 201, 202, 203, 204, 205, 206 } }
                }
            },
            { "Area2", new Dictionary<string, List<int>>
                {
                    { "House3", new List<int> { 300, 301, 302, 303, 304, 305, 306 } },
                    { "House4", new List<int> { 400, 401, 402, 403, 404, 405, 406 } }
                }
            }
        };

        Dictionary<string, List<string>> areaMeters = new Dictionary<string, List<string>>
        {
            { "Area1", new List<string> { "MTR001", "MTR002", "MTR003" } },
            { "Area2", new List<string> { "MTR004", "MTR005" } }
        };

        List<Dictionary<string, string>> complaints = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string>
            {
                { "HouseNumber", "House1" },
                { "MeterNum", "MTR001" },
                { "Issue", "Power outage" },
                { "Date", "2025-08-27" }
            },
            new Dictionary<string, string>
            {
                { "HouseNumber", "House2" },
                { "MeterNum", "MTR002" },
                { "Issue", "Meter not working" },
                { "Date", "2025-08-28" }
            },
            new Dictionary<string, string>
            {
                { "HouseNumber", "House3" },
                { "MeterNum", "MTR004" },
                { "Issue", "Incorrect reading" },
                { "Date", "2025-08-29" }
            }
        };

        int nightReadingDay3 = meterReadingsWeek[2][2]; 
        Console.WriteLine("Night reading of Day 3: " + nightReadingDay3);

        // Output 2: All readings of a specific house
        string area = "Area1";
        string house = "House2";

        if (areaData.ContainsKey(area) && areaData[area].ContainsKey(house))
        {
            List<int> readings = areaData[area][house];
            Console.WriteLine("\nReadings of " + house + " in " + area + ":");
            for (int i = 0; i < readings.Count; i++)
            {
                Console.Write(readings[i] + " ");
            }
            Console.WriteLine();
        }

        string selectedArea = "Area2";
        if (areaMeters.ContainsKey(selectedArea))
        {
            Console.WriteLine("\nMeters in " + selectedArea + ":");
            List<string> meters = areaMeters[selectedArea];
            for (int i = 0; i < meters.Count; i++)
            {
                Console.WriteLine(meters[i]);
            }
        }

        // Output 4: All complaints
        Console.WriteLine("\nAll complaints:");
        for (int i = 0; i < complaints.Count; i++)
        {
            Dictionary<string, string> complaint = complaints[i];
            Console.WriteLine(
                "House: " + complaint["HouseNumber"] +
                ", Meter: " + complaint["MeterNum"] +
                ", Issue: " + complaint["Issue"] +
                ", Date: " + complaint["Date"]
            );
        }
    }
}

