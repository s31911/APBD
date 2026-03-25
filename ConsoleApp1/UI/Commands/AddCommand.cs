namespace ConsoleApp1.UI.Commands;

public class AddCommand : MyCommand
{

    public AddCommand()
    {
        Name = "add";
    }
    public override void Execute()
    {
        Console.WriteLine("What would you like to add? ");        
        Console.WriteLine("Possible options: {person = p} {equipment = e} ");       
        
        switch (Console.ReadLine())
        {
            case "p":
            case "person":
                AddPersonCommand addPersonCommand = new AddPersonCommand();
                addPersonCommand.Execute();
                
                break;
            case "e":
            case "equipment":
                AddEquipmentCommand addEquipmentCommand = new AddEquipmentCommand();
                addEquipmentCommand.Execute();
                break;
            default:
                CommandNotValid();
                break;
        }


    }

}