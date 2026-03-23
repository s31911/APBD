using ConsoleApp1.rentals;

namespace ConsoleApp1.Exceptions;

public class EquipmentUnavalibleForRentException : Exception
{

    public EquipmentUnavalibleForRentException(string message) : base(message)
    {
        
    }

    public EquipmentUnavalibleForRentException(Rental rental)
        : base($"Tried to rent Unavailable equipment: {rental.Equipment} by {rental.Person}")
    {
        
        
    }
}