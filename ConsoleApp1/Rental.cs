using ConsoleApp1.Exceptions;
using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1;

public class Rental
{
    #nullable enable
    public static List<Rental> Rentals = new List<Rental>();
    private static int _lastId = 0;

    public int id = GetNewId();
    public DateTime RentDate { get; set; }
    public DateTime PlanedReturnDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public Equipment Equipment{ get; set; }
    public Person Person { get; set; }

    public Rental()
    {
        
    }

    private static int GetNewId()
    {
        return _lastId++;
    }
    public Rental(Equipment equipment, Person person, DateTime planedReturnDate)
    {

        if (person.GetRentLimit() < person.CurrentlyRent + 1) throw new RentalLimitExceededException(person);
        if (equipment.Availability == Equipment.AvailabilityStatus.Unavailable) throw new EquipmentUnavalibleForRentException(this);
        id = _lastId++;
        Person = person;
        Equipment = equipment;
        equipment.Availability = Equipment.AvailabilityStatus.Unavailable;
        PlanedReturnDate = planedReturnDate;
        RentDate = DateTime.Now;
        Rentals.Add(this);
    }
    public Rental(Equipment equipment, Person person,DateTime planedReturnDate,DateTime rentDate)
    : this(equipment, person,planedReturnDate)
    {
        RentDate = rentDate;
    }

    public void ReturnItem()
    {
        ReturnDate = DateTime.Now;
        Equipment.Availability = Equipment.AvailabilityStatus.Available;
        Person.CurrentlyRent--;
        if (ReturnDate > PlanedReturnDate) Person.ImposeFine(((ReturnDate ?? throw new Exception("No return Date on returning item")) - PlanedReturnDate ).TotalDays );
    }

    public override string ToString()
    {
        return $"Rental #{id}: {Equipment} RENTED BY {Person} ON {RentDate} Planned return: {PlanedReturnDate} Actual Return: {(ReturnDate.ToString() ?? "Not yed returned" )}";
    }

    public static void ShowAllRentals()
    {
        foreach (var rental in Rentals)
        {
            Console.WriteLine(rental);
        }
    }
    public static void ShowExpiredRentals()
    {
        foreach (var rental in Rentals)
        {
            if (rental.PlanedReturnDate < rental.ReturnDate)
            {
                Console.WriteLine(rental);
            }
        }  
        
    }
    public static void ShowReport()
    {
        Console.WriteLine($"Total Rentals: {Rentals.Count}");
    }
}