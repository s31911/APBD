using System.Linq.Expressions;

namespace ConsoleApp1.UI.Commands;
using ConsoleApp1.rentals;

public class AddEquipmentCommand : MyCommand
{

    public AddEquipmentCommand()
    {
        Name = "add equipment";
    }

    public override void Execute()
    {
        try{
            Console.WriteLine("Please enter equipments Name: ");
            string equipmentName = Console.ReadLine();
            Console.WriteLine("Please enter avalibility status (0 -> available, 1 -> not available ): ");
            int status = int.Parse(Console.ReadLine());
            Equipment.AvailabilityStatus value = (Equipment.AvailabilityStatus)status;
           
            Console.WriteLine("What type of equipment would you like to add? ");
            Console.WriteLine("Possible options: {camera = c} {laptop = l} {projector = p} ");
            switch (Console.ReadLine())
            {
                case "c":
                case "camera":
                    Console.WriteLine("Please enter cameras producent: ");
                    string producent = Console.ReadLine();
                    Console.WriteLine("Please enter starage capacity (number): ");
                    int size =int.Parse( Console.ReadLine());

                    new Camera(equipmentName, value, producent,size);
                    CommandExecutedSuccessfully();
                    break;
                case "l":
                case "laptop":
                    Console.WriteLine("Please enter laptop Name: ");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Please enter starage capacity (number): ");
                    int storagecapacity =int.Parse( Console.ReadLine());
                    
                    new Laptop(equipmentName,value,storagecapacity, brand);
                    
                    CommandExecutedSuccessfully();
                    break;
                case "p":
                case "projector":
                    Console.WriteLine("Please enter projector resolution: ");
                    string resolution = Console.ReadLine();
                    Console.WriteLine("Please enter brightness(number): ");
                    int brightness =int.Parse( Console.ReadLine());
                    
                    new Projector(equipmentName,value,brightness, resolution);
                    CommandExecutedSuccessfully();
                    break;
                default:
                    CommandNotValid();
                    break;
            }
            
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
            CommandNotValid();
        }
    }
}