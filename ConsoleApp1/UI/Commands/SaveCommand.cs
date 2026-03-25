namespace ConsoleApp1.UI.Commands;

public class SaveCommand : MyCommand
{
    public SaveCommand()
    {
        Name = "save";
    }

    public override void Execute()
    {
        Program.AppDatabase.SaveToFile();
    }
}
