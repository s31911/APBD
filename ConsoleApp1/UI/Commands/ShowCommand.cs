using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1.UI.Commands;

public class ShowCommand : MyCommand
{
    public ShowCommand()
    {
        Name = "show";
    }

    public override void Execute()
    {
        Console.WriteLine("What would you like to show?");
        Console.WriteLine("Possible options: {persons} {equipment} {availableequipment} {fullreport}{rentalreport} {equipmentreport} {personreport}");

        switch (Console.ReadLine())
        {
            case "persons":
                Person.ShowAllPersons();
                break;
            case "equipment":
                Equipment.ShowAllEquipments();
                break;
            case "availableequipment":
                Equipment.ShowAvailableEquipments();
                
                break;
            case "fullreport":
                    Rental.ShowReport();
                    Equipment.ShowReport();
                    Person.ShowReport();
                
                break;
            case "rentalreport":
                    Rental.ShowReport();
                break;
            case "equipmenteeport":
                    Equipment.ShowReport();
                break;
            case "personreport":
                    Person.ShowReport();
                break;
            
            default:
                Console.WriteLine("That is not a valid option!");
                break;
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();  
        
    }
    
}