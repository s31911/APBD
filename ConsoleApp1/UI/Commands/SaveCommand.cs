namespace ConsoleApp1.UI.Commands;

public class SaveCommand : MyCommand
{
    public SaveCommand()
    {
        Name = "save";
    }

    public override void Execute()
    {
        try
        {
            Console.WriteLine("Trying to save a file. Please Stand by...");
            Program.AppDatabase.SaveAllToFile();
            CommandExecutedSuccessfully();
        }
        catch (Exception e)
        {
            Console.WriteLine("Couldn't save the file. " + e.Message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
