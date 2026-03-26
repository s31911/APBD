using System.Text.Json.Serialization;
using ConsoleApp1.persons;

namespace ConsoleApp1.rentals;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(Camera), "Camera")]
[JsonDerivedType(typeof(Laptop), "Laptop")]
[JsonDerivedType(typeof(Projector), "Projector")]

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

    public Equipment()
    {
        
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
            if(equipment.Availability == AvailabilityStatus.Unavailable && 
               Rental.Rentals.TrueForAll(x=>!x.Equipment.Equals(equipment))) Console.WriteLine(equipment);
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
        Console.WriteLine($"Equipments: |Available : {available} |Unavailable : {unavailable}|Total : {Equipments.Count}| ");

    }
    
}