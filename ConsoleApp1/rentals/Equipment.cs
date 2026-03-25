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
        Available ,Unavailable
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

    public override string ToString()
    {
        return $"Equipment #{Id}  - {Name} availability: {Availability}";
    }

    public static List<Equipment> GetEquipments()
    {
        return Equipments;
    }

    public static void ShowAllEquipments()
    {
        foreach (var equipment in Equipments)
        {
            Console.WriteLine(equipment);
        }
    }
    public static void ShowAvailableEquipments()
    {
        foreach (var equipment in Equipments)
        {
            if(equipment.Availability == AvailabilityStatus.Available) Console.WriteLine(equipment);
        }
    }
    public static void ShowUnavailableEquipments()
    {
        foreach (var equipment in Equipments)
        {
            if(equipment.Availability == AvailabilityStatus.Unavailable) Console.WriteLine(equipment);
        }
    }

    public static void ShowReport()
    {
        int available = 0;
        int unavailable = 0;

        foreach (var equipment in Equipments)
        {
            if (equipment.Availability == AvailabilityStatus.Unavailable)
            {
                unavailable++;
            }
            else
            {
                available++;
            }
        }
        Console.WriteLine($"Equipments: |Available : {available} |Unavailable : {unavailable}|Total : {Equipments.Count}|");

    }
    
}