// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public enum MeterStatus
{
    Active,
    Inactive,
    Fault
}

public struct Reading
{
    public DateTime Date;
    public int Units;

    public Reading(DateTime date, int units)
    {
        Date = date;
        Units = units;
    }
}

public abstract class Notifier
{
    public abstract void SendMessage(string msg);
}

public class SmsNotifier : Notifier
{
    private string phone;

    public SmsNotifier(string phone)
    {
        this.phone = phone;
    }

    public override void SendMessage(string msg)
    {
        Console.WriteLine("SMS to " + phone + ": " + msg);
    }
}

public class EmailNotifier : Notifier
{
    private string email;

    public EmailNotifier(string email)
    {
        this.email = email;
    }

    public override void SendMessage(string msg)
    {
        Console.WriteLine("Email to " + email + ": " + msg);
    }
}

public static class Tariff
{
    public static decimal RatePerUnit = 5.0m;
}

public sealed class BillCalculator
{
    public static decimal CalculateBill(List<Reading> readings)
    {
        int totalUnits = 0;
        for (int i = 0; i < readings.Count; i++)
        {
            totalUnits += readings[i].Units;
        }
        return totalUnits * Tariff.RatePerUnit;
    }
}

// Partial Class - Customer (both parts in one file)
public partial class Customer
{
    public string Name;
    public string? Email;
}

public partial class Customer
{
    public string Phone;
}

public class Meter
{
    public string MeterId;
    public MeterStatus Status;
    public ReadingHistory History;

    public Meter(string meterId)
    {
        MeterId = meterId;
        Status = MeterStatus.Active;
        History = new ReadingHistory();
    }

    // Event: Trigger when new reading is added
    public event Action<Reading> OnReadingAdded;

    public void AddReading(Reading reading)
    {
        History.Readings.Add(reading);

        if (OnReadingAdded != null)
        {
            OnReadingAdded.Invoke(reading);
        }
    }

    // Nested Class
    public class ReadingHistory
    {
        public List<Reading> Readings = new List<Reading>();
    }
}

class Program
{
    static void Main()
    {
        // Create a customer with only phone (email is null)
        Customer customer = new Customer
        {
            Name = "Alice",
            Email = null,
            Phone = "1234567890"
        };

        // Create meter and notifier based on available contact
        Meter meter = new Meter("MTR001");

        Notifier notifier = customer.Email != null
            ? (Notifier)new EmailNotifier(customer.Email)
            : new SmsNotifier(customer.Phone);

        // Subscribe to reading-added event
        meter.OnReadingAdded += (Reading reading) =>
        {
            notifier.SendMessage(
                "New reading added on " + reading.Date.ToShortDateString() +
                " with " + reading.Units + " units."
            );
        };

        // Add some readings
        meter.AddReading(new Reading(DateTime.Now.AddDays(-2), 50));
        meter.AddReading(new Reading(DateTime.Now, 75));

        // Generate and print bill
        decimal bill = BillCalculator.CalculateBill(meter.History.Readings);
        Console.WriteLine("Total bill: " + bill);
    }
}

