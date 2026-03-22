namespace ConsoleApp1.persons;

public class Student : Person
{
    public static int RentalLimit = 5;

    Student( string firstName, string lastName) : base(firstName, lastName)
    {
        
    }
    public override int GetRentLimit()
    {
        return RentalLimit;
    }
    public void ChangeRentalLimit(int newLimit)
    {
        //TODO
        // check for equiptment that have been given out?
        // i need to chaeck if somebody exceeds new limit 
        RentalLimit = newLimit;
    }
 
}