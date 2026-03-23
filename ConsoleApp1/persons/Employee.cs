namespace ConsoleApp1.persons;

public class Employee : Person
{
    public static int RentalLimit = 5;

    Employee(string firstName, string lastName) : base(firstName, lastName)
    {
        
    }

    public override int GetRentLimit()
    {
        return RentalLimit;
    }
    public override void ImposeFine(double numberOfDays)
    {
        // TODO
        // wymysl jaka kare   
    }
}