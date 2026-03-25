namespace ConsoleApp1.UI.Commands;

public class LoadCommand : MyCommand
{
    LoadCommand()
    {
    Name = "save";
    }        

    public override void Execute()
    {
        Program.AppDatabase.LoadFromFile();
    }
}