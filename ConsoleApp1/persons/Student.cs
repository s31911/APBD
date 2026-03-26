namespace ConsoleApp1.persons;

public class Student : Person
{
    private static int RentalLimit = 2;

    public Student( string firstName, string lastName) : base(firstName, lastName)
    {
        
    }
    public override int GetRentLimit()
    {
        return RentalLimit;
    }
    public void ChangeRentalLimit(int newLimit)
    {
        RentalLimit = newLimit;
    }

    public override void ImposeFine(double numberOfDays)
    {
        CurrentlyRent++;
    }

 
}