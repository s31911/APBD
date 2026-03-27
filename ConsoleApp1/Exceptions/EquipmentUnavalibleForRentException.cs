using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1.Exceptions;

public class EquipmentUnavalibleForRentException : Exception
{

    public EquipmentUnavalibleForRentException(string message) : base(message)
    {
        
    }

    public EquipmentUnavalibleForRentException(Equipment equipment,Person person)
        : base($"Tried to rent Unavailable equipment: {equipment} by {person}")
    {
        
        
    }
}