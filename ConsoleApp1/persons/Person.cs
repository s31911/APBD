namespace ConsoleApp1.persons;

public abstract class Person 
{
    private static int _lastId = 0;
    public static List<Person> persons = new List<Person>();
    public int Id = GetNewId();
    public int CurrentlyRent = 0;
    
    
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        persons.Add(this);
    }
    
    private static int GetNewId()
    {
        return _lastId++;
    }
    public int GetId()
    {
        return Id;
    }

    public static List<Person> GetPersons()
    {
        return persons;
    }

    public abstract int GetRentLimit();

    public string GetFullName() => FirstName + " " + LastName;
}   