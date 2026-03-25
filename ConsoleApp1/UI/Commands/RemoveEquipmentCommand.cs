using ConsoleApp1.rentals;

namespace ConsoleApp1.UI.Commands;

public class RemoveEquipmentCommand : MyCommand
{
    public RemoveEquipmentCommand()
    {
        Name = "remove equipment";
    }

    public override void Execute()
    {
        Equipment.ShowAllEquipments();
        Console.WriteLine("Please enter id of equipment you want removed ");
        try
        {
            int idToRemove = int.Parse(Console.ReadLine());
            Equipment.Equipments.RemoveAll(x => x.Id == idToRemove);
        }
        catch (Exception ignored)
        {
            Console.WriteLine("Please enter a valid id");
            Console.ReadKey();    
        }
    }
}