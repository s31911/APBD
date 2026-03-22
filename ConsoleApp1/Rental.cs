using ConsoleApp1.Exceptions;
using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1;

public class Rental
{
    public DateTime RentDate { get; set; }
    public DateTime PlanedReturnDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public Equipment Equipment{ get; set; }
    public Person Person { get; set; }
    public Rental(Equipment equipment, Person person, DateTime planedReturnDate)
    {
        // TODO dokonczyc rental
        // potrzebujemy na pewno w equipment metody Rent() zeby dzia

        if (person.GetRentLimit() > person.CurrentlyRent + 1) throw new RentalLimitExceededException(person);
        
        Person = person;
        Equipment = equipment;
        PlanedReturnDate = planedReturnDate;
        RentDate = DateTime.Now;
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
    }
}