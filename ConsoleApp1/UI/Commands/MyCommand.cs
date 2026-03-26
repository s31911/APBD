namespace ConsoleApp1.UI.Commands;

public abstract class MyCommand
{
    public string Name { get; set; }
    
    public  abstract void Execute();


    public void CommandNotValid()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Thats not a valid command!");
        Console.ResetColor();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();    
    }

    public void CommandExecutedSuccessfully()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Command Executed Successfully!");
        Console.ResetColor();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();   
    }


    
    
}