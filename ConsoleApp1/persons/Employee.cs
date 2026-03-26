namespace ConsoleApp1.persons;

public class Employee : Person
{
    private static int RentalLimit = 5;

    public Employee(string firstName, string lastName) : base(firstName, lastName)
    {
        
    }
    public void ChangeRentalLimit(int newLimit)
    {
        RentalLimit = newLimit;
    }

    public override int GetRentLimit()
    {
        return RentalLimit;
    }
    public override void ImposeFine(double numberOfDays)
    {
        CurrentlyRent++;
    }
}