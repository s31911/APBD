using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1.UI.Commands;

public class ReturnCommand : MyCommand
{

    public ReturnCommand()
    {
        Name = "return";
    }

    public override void Execute()
    {
        
        try
        {

            // Console.Clear();
            Person.ShowAllPersons();
            Console.WriteLine("Select id of person to who would like to return equipment");
            Person? person = Person.persons.Find(x => x.Id == int.Parse(Console.ReadLine()));
            
            Console.WriteLine("NEXT");
            
            // Console.Clear();
            person.ShowRentedEquipment();
            Console.WriteLine("What id would you like to return?");
            
            Console.WriteLine("NEXT2");
            
            // Console.Clear();
            Rental? rental = Rental.Rentals.Find(x=>x.id==int.Parse(Console.ReadLine()));
            rental.ReturnItem();
            CommandExecutedSuccessfully();            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
        
        
    }
}