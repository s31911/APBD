using System.Text.Json;
using System.Text.Json.Serialization;
using ConsoleApp1.persons;
using ConsoleApp1.rentals;

namespace ConsoleApp1.Database;

public class AppDatabase
{

    // public static Hash
    private string _defaultFileName = "database.json";
    private string _persons_fileName = "persons.json";
    private string _equipment_fileName = "equipment.json";
    private string _rental_fileName = "rentals.json";
    private JsonSerializerOptions options = new JsonSerializerOptions
    {
        ReferenceHandler = ReferenceHandler.Preserve,
        WriteIndented = true
    };

    
    public void LoadAllFromFile()
    {
            Person.persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(_persons_fileName));
            Equipment.Equipments = JsonSerializer.Deserialize<List<Equipment>>(File.ReadAllText(_equipment_fileName));
            Rental.Rentals = JsonSerializer.Deserialize<List<Rental>>(File.ReadAllText(_rental_fileName),options);
            
    }

    public void SaveAllToFile()
    {
        File.WriteAllText(_persons_fileName,JsonSerializer.Serialize(Person.persons));
        File.WriteAllText(_equipment_fileName,JsonSerializer.Serialize(Equipment.Equipments));
        File.WriteAllText(_rental_fileName,JsonSerializer.Serialize(Rental.Rentals,options));
        
    }

    public void AutoLoad()
    {
        try
        {
            LoadAllFromFile();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.Write("Autoload failed.");
            
            for (int i = 1; i < 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000*i);
                
            }
            Console.Clear();
        }
        
    }
}