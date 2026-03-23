using ConsoleApp1.Exceptions;
using ConsoleApp1.rentals;

namespace ConsoleApp1.persons;

public abstract class Person 
{
    private static int _lastId = 0;
    public static List<Person> persons = new List<Person>();
    public int Id = GetNewId();
    public int CurrentlyRent = 0;
    
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        persons.Add(this);
    }

    public override string ToString()
    {
        return "#"+ Id +" | "+GetFullName();
    }

    private static int GetNewId()
    {
        return _lastId++;
    }
    public int GetId()
    {
        return Id;
    }

    public static List<Person> GetPersons()
    {
        return persons;
    }

    public void ShowRentedEquipment()
    {
        foreach (var rental in Rental.Rentals)
        {
            if (rental.Person == this && rental.ReturnDate == null)
            {
                Console.Write(rental);
            }
        }
    }

    public abstract int GetRentLimit();

    public string GetFullName() => FirstName + " " + LastName;
    public abstract void ImposeFine(double numberOfDays);
    public static void ShowReport()
    {
        int numberOfStudents = 0;
        int numberOfEmployees= 0;
        foreach (var person in persons)
        {
            // if(person.GetType()  == typeof(Student))
            if(person is Student)

            {
                numberOfStudents++;
            }
            else
            {
                numberOfEmployees++;
            }

        }   
        Console.WriteLine($"Total Persons in system: {persons.Count} ->  {numberOfStudents} students | {numberOfEmployees} employees");
    }
}   