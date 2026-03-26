using ConsoleApp1.Exceptions;
using ConsoleApp1.persons;
using ConsoleApp1.rentals;
using ConsoleApp1.UI;

namespace ConsoleApp1;
    
using ConsoleApp1.Database;

public class Program
{

    public static AppDatabase AppDatabase = new AppDatabase();
    public static bool exit = false;
    public static void Main()
    {
        AppDatabase.AutoLoad();
        UiHandler  uiHandler = new UiHandler();
        while (exit == false)
        {
            uiHandler.handle(Console.ReadLine());
            
        }
        Console.Write("Thank you for using our app.");
    }

    public static void Test()
    {
        Student stud = new Student("Jan","Kowalski");
        Student stud2 = new Student("Anna","Malinowska");
        new Employee("Employee","Emplojowski");

        Camera eq1 = new Camera("Camera1",Equipment.AvailabilityStatus.Available,"prod",12);
        Projector eq2 = new Projector("Camera1",Equipment.AvailabilityStatus.Available,400,"12x14");
        Laptop eq3 = new Laptop("Camera1",Equipment.AvailabilityStatus.Available,12,"brand");

        new Rental(eq1, stud,DateTime.Now);
        new Rental(eq2, stud,DateTime.Now);
        
        try
        {
            // Wypozyczenie ponad limit 2 dla studenta
            new Rental(eq3, stud,DateTime.Now);
            
        }
        catch (RentalLimitExceededException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
        try
        {
            // Wypozyczenie niedostępnego sprzętu
            new Rental(eq2, stud2,DateTime.Now);
            
        }
        catch (EquipmentUnavalibleForRentException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
        
            
    }
}


//TODO
// 1. Dodanie nowego użytkownika do systemu. (DONE) 
// 2. Dodanie nowego sprzętu danego typu. (DONE)
// 3. Wyświetlenie listy całego sprzętu z aktualnym statusem. (DONE)
// 4. Wyświetlenie wyłącznie sprzętu dostępnego do wypożyczenia. (DONE)
// 5. Wypożyczenie sprzętu użytkownikowi. (DONE)
// 6. Zwrot sprzętu wraz z przeliczeniem ewentualnej kary za opóźnienie.(DONE)
// 7. Oznaczenie sprzętu jako niedostępnego, np. z powodu uszkodzenia lub serwisu. (DONE)
// 8. Wyświetlenie aktywnych wypożyczeń danego użytkownika. (Done) // przy zwrocie sie wyświetlają aktywne wypożyczenia
// 9. Wyświetlenie listy przeterminowanych wypożyczeń.(DONE)
// 10. Wygenerowanie krótkiego raportu podsumowującego stan wypożyczalni. (DONE)
