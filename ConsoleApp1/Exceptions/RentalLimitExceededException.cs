using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1.Exceptions;

public class RentalLimitExceededException : Exception
{
    public int RentalLimit{get; set;}
    public int Id{get; set;}
    public string FullName{get; set;}
    public Equipment? RentedEquipment {get; set;}

    
    public RentalLimitExceededException(Person person) 
        : base($"Person with id: {person.Id} and name {person.GetFullName()}tried to exceed the maximum limit of {person.GetRentLimit()}")
    {
        
        RentalLimit = person.GetRentLimit();
        Id = person.Id;
        FullName = person.GetFullName();
    }

    public RentalLimitExceededException(Person person, Equipment equipment) : this(person)
    {
        RentalLimit = person.GetRentLimit();
        Id = person.Id;
        FullName = person.GetFullName();
        RentedEquipment = equipment;
    }

    public override string ToString()
    {
        string equipmentMessage = ""; 
        if(RentedEquipment != null) equipmentMessage = $"trying to rent {RentedEquipment.Id} {RentedEquipment.Name}";
        return "Person: " + Id + FullName + "Exceeded Rental limit of: "+ RentalLimit+ equipmentMessage + base.ToString();
    }
}