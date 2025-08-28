// See https://aka.ms/new-console-template for more information
using System;

abstract class MeterReading
{
    public abstract int CalculateBill(int units);
}


class ResidentialReading : MeterReading
{
    public override int CalculateBill(int units)
    {
        return units * 5;
    }
}


class CommercialReading : MeterReading
{
    public override int CalculateBill(int units)
    {
        return units * 8;
    }
}

class Program
{
    static void Main()
    {
        MeterReading residential = new ResidentialReading();
        MeterReading commercial = new CommercialReading();

        int resUnits = 100;
        int comUnits = 100;

        int resBill = residential.CalculateBill(resUnits);
        int comBill = commercial.CalculateBill(comUnits);

        Console.WriteLine("Residential Bill = " + resBill); 
        Console.WriteLine("Commercial Bill = " + comBill);    
    }
}

