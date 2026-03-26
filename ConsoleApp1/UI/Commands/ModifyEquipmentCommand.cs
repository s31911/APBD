using ConsoleApp1.rentals;

namespace ConsoleApp1.UI.Commands;

public class ModifyEquipmentCommand : MyCommand
{
    public ModifyEquipmentCommand()
    {
        Name = "modify equipment";
    }

    public override void Execute()
    {
        try
        {
            Console.Clear();
            
            Console.Write("What would you like to do to equipment? ");
            Console.Write("Possible options to make equipment: {unavailable = u} {available = a}");
            
            switch (Console.ReadLine())
            {
                case "u":
                case "unavailable":
                    Equipment.ShowAvailableEquipments();
                    Console.WriteLine("Please enter id of equipment you want to make unavailable ");
                    Equipment eq1 = Equipment.Equipments.Find(x => x.Id == int.Parse(Console.ReadLine()));
                    // technicznie to powinno zostać za pomoca funkcji a nie recznej zmiany pola
                    eq1.Availability = Equipment.AvailabilityStatus.Unavailable;

                    break;
                
                case "a":
                case "available":
                    Equipment.ShowUnavailableEquipments();
                    Console.WriteLine("Please enter id of equipment you want to make available ");
                    Equipment eq = Equipment.Equipments.Find(x=>x.Id == int.Parse(Console.ReadLine()));
                    // technicznie to powinno zostać za pomoca funkcji a nie recznej zmiany pola
                    eq.Availability = Equipment.AvailabilityStatus.Available;
                    break;
                default:
                    CommandNotValid();
                    break;
            }
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}