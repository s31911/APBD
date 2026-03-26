using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1.UI.Commands;

public class ShowCommand : MyCommand
{
    private bool exit = false;
    public ShowCommand()
    {
        Name = "show";
    }
    

    public override void Execute()
    {
        while (exit == false)
        {
            Console.Clear();
            Console.WriteLine("What would you like to show?");
            Console.WriteLine("Possible options: {rental = r} {persons = p} {equipment = e} {availableequipment = ae} {fullreport = fr}");
            Console.WriteLine("{rentalreport = rr} {equipmentreport = er} {personreport = pr}");
            Console.WriteLine("{exit = q}");

            switch (Console.ReadLine())
            {
                case "p":
                case "persons":
                    Person.ShowAllPersons();
                    break;
                case "e":
                case "equipment":
                    Equipment.ShowAllEquipments();
                    break;
                
                case "r":
                case "rental":
                    Rental.ShowAllRentals();
                    break;
                case "ae":
                case "availableequipment":
                    Equipment.ShowAvailableEquipments();
                    
                    break;
                case "fr" :
                case "fullreport":
                        Rental.ShowReport();
                        Equipment.ShowReport();
                        Person.ShowReport();
                    
                    break;
                case "rr" :
                case "rentalreport":
                        Rental.ShowReport();
                    break;
                case "ee":
                case "equipmenteeport":
                        Equipment.ShowReport();
                    break;
                case "pr" :
                case "personreport":
                        Person.ShowReport();
                    break;
                case  "q":
                case "exit":
                        exit = true;
                        break;
                default:
                    Console.WriteLine("That is not a valid option!");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();  
        }

        exit = false;
    }
    
}