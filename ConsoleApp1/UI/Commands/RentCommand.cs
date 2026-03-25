using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1.UI.Commands;

public class RentCommand : MyCommand
{
    public RentCommand()
    {
        Name =  "rent";
    }

    public override void Execute()
    {
        try
        {
            Console.Clear();
            Equipment.ShowAvailableEquipments();

            Console.WriteLine("Select id of what you would like to rent");
            Equipment? equipment = Equipment.Equipments.Find(x => x.Id == int.Parse(Console.ReadLine()));

            Console.Clear();
            Person.ShowAllPersons();

            Console.WriteLine("Select id of person to whom you would like to rent");
            Person? person = Person.persons.Find(x => x.Id == int.Parse(Console.ReadLine()));

            Console.Clear();
            Console.WriteLine("Whats the planned return?");
            DateTime returnDate = DateTime.Parse(Console.ReadLine());

            new Rental(equipment, person, returnDate);
            
            CommandExecutedSuccessfully();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }
}