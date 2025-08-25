using System;

class Customer
{
    public int CustomerID;
    public string Name;
    public int UnitsConsumed;

    public Customer(int customerID, string name, int unitsConsumed)
    {
        CustomerID = customerID;
        Name = name;
        UnitsConsumed = unitsConsumed;
    }

    public void ShowBill()
    {
        int billAmount = UnitsConsumed * 5; 
        Console.WriteLine("\nCustomer: " + Name + " (ID: " + CustomerID + ")");
        Console.WriteLine("Units Consumed: " + UnitsConsumed);
        Console.WriteLine("Total Bill: $" + billAmount);
    }
}

class Program
{
    //static void Main(string[] args)
    //{
    //    Console.Write("Enter Customer ID: ");
    //    int id = Convert.ToInt32(Console.ReadLine());

    //    Console.Write("Enter Name: ");
    //    string name = Console.ReadLine();

    //    Console.Write("Enter Units Consumed: ");
    //    int units = Convert.ToInt32(Console.ReadLine());

    //    Customer customer = new Customer(id, name, units);
    //    customer.ShowBill();
    //}
}
