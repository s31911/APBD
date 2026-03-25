using ConsoleApp1.UI.Commands;

namespace ConsoleApp1.UI;

public class UiHandler : IsUiHandler
{
    
    private List<MyCommand> commands = new List<MyCommand>();
    
    public UiHandler()
    {
        commands.Add(new AddCommand());
        commands.Add(new ShowCommand());
        commands.Add(new RemoveEquipmentCommand());
        commands.Add(new RemovePersonCommand());
        commands.Add(new RentCommand());
        commands.Add(new ReturnCommand());

        
        ShowUiScreen();
    }

    public void handle(string? inputText)
    {
        // Console.Clear();
        if (inputText == null)
        {
            CommandNotValid();  
            
        }
        else
        {

            inputText = inputText.Trim();
            inputText = inputText.ToLower();

            switch (inputText)
            {
                case "clear":
                    break;
                case "q":
                case "exit":
                    Program.exit = true;
                    break;
                default:
                    bool commandExists = false;
                    foreach (var command in commands)
                    {
                        if (command.Name == inputText)
                        {
                            commandExists = true;
                            Console.Clear();
                            command.Execute();
                        }
                    }
                    if(!commandExists)CommandNotValid();
                    break;
            }
        }

        Console.Clear();
        ShowUiScreen();
        
    }
    private void ShowUiScreen()
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("Welcome to {APP NAME}");
        Console.WriteLine("App works by you inputing commands on command line");
        Console.WriteLine("Possible commands:");
        foreach (var command in commands)
        {
            Console.WriteLine(command.Name);
        }
        Console.WriteLine("exit");
        Console.WriteLine("===========================================");
        Console.WriteLine("");
    }

    private void CommandNotValid()
    {
        Console.WriteLine("Thats not a valid command");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();    
    }
    
    
}