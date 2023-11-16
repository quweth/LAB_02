using System;

class Address
{
    private int index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public int Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address();
        myAddress.Index = 01103;
        myAddress.Country = "Ukraine";
        myAddress.City = "Kyiv";
        myAddress.Street = "Dragomirova";
        myAddress.House = "8";
        myAddress.Apartment = "A";

        Console.WriteLine($"Index: {myAddress.Index}");
        Console.WriteLine($"Country: {myAddress.Country}");
        Console.WriteLine($"City: {myAddress.City}");
        Console.WriteLine($"Street: {myAddress.Street}");
        Console.WriteLine($"House: {myAddress.House}");
        Console.WriteLine($"Apartment: {myAddress.Apartment}");
    }
}
