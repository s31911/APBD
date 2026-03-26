namespace ConsoleApp1.UI.Commands;

public class LoadCommand : MyCommand
{
    public LoadCommand()
    {
        Name = "load";
    }        

    public override void Execute()
    {
        try
        {

            Console.WriteLine("Trying to load data from a file. Please Stand by...");
            Program.AppDatabase.LoadAllFromFile();
            CommandExecutedSuccessfully();
        }
        catch (Exception e)
        {
            Console.WriteLine("Couldn't save the file. Reason: " + e.Message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
        
    }
}