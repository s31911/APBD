namespace ConsoleApp1.UI.Commands;

public abstract class MyCommand
{
    public string Name { get; set; }
    
    public  abstract void Execute();


    public void CommandNotValid()
    {
        Console.WriteLine("Thats not a valid command!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();    
    }

    public void CommandExecutedSuccessfully()
    {
        Console.WriteLine("Command Executed Successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();   
    }


    
    
}