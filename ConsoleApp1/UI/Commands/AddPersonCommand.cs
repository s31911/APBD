using ConsoleApp1.persons;

namespace ConsoleApp1.UI.Commands;

public class AddPersonCommand : MyCommand
{
    public AddPersonCommand()
    {
        Name = "add person";
    }

    public override void Execute()
    {
        Console.WriteLine("Please enter a first Name: ");
        string? firstName = Console.ReadLine();
        Console.WriteLine("Please enter last Name: ");
        string? lastName = Console.ReadLine();
        if (firstName is null || lastName is null)
        {
            Console.WriteLine("You have to enter a first name and last name!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();  
        }
        else
        {
            Console.WriteLine("What type of person would you like to add? ");
            Console.WriteLine("Possible options: {employee = e} {student = s} ");
            switch (Console.ReadLine())
            {
                case "s":
                case "student":
                    new Student(firstName, lastName);
                    CommandExecutedSuccessfully();
                    break;
                case "e":
                case "employee":
                    new Employee(firstName, lastName);
                    CommandExecutedSuccessfully();
                    break;
                default:
                    CommandNotValid();                    
                    break;
            } 
            
        }
    }
}