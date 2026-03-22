namespace ConsoleApp1.rentals;

public abstract class Equipment
{
    private static int _lastId = 0;
    public static List<Equipment> Equipments = new List<Equipment>();
    public int Id = GetNewId();
    public string Name {get; set;}
    public AvailabilityStatus Availability {get; set;}
    public enum AvailabilityStatus
    {
        Available,Unavailable
    }
    protected Equipment(string name,AvailabilityStatus status) 
    {
        Name = name;
        Availability = status;
        Equipments.Add(this);
    }
    private static int GetNewId()
    {
        return _lastId++;
    }
    public int GetId()
    {
        return Id;
    }

    public static List<Equipment> GetEquipments()
    {
        return Equipments;
    }


}