namespace ConsoleApp1.rentals;

public class Laptop : Equipment
{
    public int StorageCapacity { get; set; }
    public string Brand { get; set; }
    
    public Laptop(string name, AvailabilityStatus status,int storageCapacity,string brand ) : base(name, status)
    {
        Brand = brand;
        StorageCapacity = storageCapacity;
    }
    
}