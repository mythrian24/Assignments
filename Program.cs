// See https://aka.ms/new-console-template for more information
using System;

class SmartMeter
{
    public int MeterId;
    public string CustomerName;

    public SmartMeter(int meterId, string customerName)
    {
        MeterId = meterId;
        CustomerName = customerName;
    }
}

class ResidentialMeter : SmartMeter
{
    public string HouseType;

    public ResidentialMeter(int meterId, string customerName, string houseType)
        : base(meterId, customerName)
    {
        HouseType = houseType;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Residential Meter -> ID: " + MeterId + ", Name: " + CustomerName + ", HouseType: " + HouseType);
    }
}

class CommercialMeter : SmartMeter
{
    public string BusinessType;

    public CommercialMeter(int meterId, string customerName, string businessType)
        : base(meterId, customerName)
    {
        BusinessType = businessType;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Commercial Meter -> ID: " + MeterId + ", Name: " + CustomerName + ", BusinessType: " + BusinessType);
    }
}

class Program
{
    static void Main()
    {
        ResidentialMeter resMeter = new ResidentialMeter(201, "Alice", "Apartment");
        CommercialMeter comMeter = new CommercialMeter(301, "Bob", "Shop");

        resMeter.PrintDetails();
        comMeter.PrintDetails();
    }
}

