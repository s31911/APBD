using ConsoleApp1.persons;

namespace ConsoleApp1.UI.Commands;

public class RemovePersonCommand : MyCommand
{
    public RemovePersonCommand()
    {
        Name = "remove person";
    }

    public override void Execute()
    {
        Person.ShowAllPersons();
        Console.WriteLine("Please enter id of Person you want removed ");
        try
        {
            int idToRemove = int.Parse(Console.ReadLine());
            Person.persons.RemoveAll(x => x.Id == idToRemove);
            CommandExecutedSuccessfully();
        }
        catch (Exception ignored)
        {
            Console.WriteLine("Please enter a valid id");
            Console.ReadKey();    
        }
    }
    
}