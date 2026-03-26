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
}


//TODO
// 1. Dodanie nowego użytkownika do systemu. (DONE) 
// 2. Dodanie nowego sprzętu danego typu. (DONE)
// 3. Wyświetlenie listy całego sprzętu z aktualnym statusem. (DONE)
// 4. Wyświetlenie wyłącznie sprzętu dostępnego do wypożyczenia. (DONE)
// 5. Wypożyczenie sprzętu użytkownikowi. (DONE)
// 6. Zwrot sprzętu wraz z przeliczeniem ewentualnej kary za opóźnienie.(DONE)
// 7. Oznaczenie sprzętu jako niedostępnego, np. z powodu uszkodzenia lub serwisu. (DONE)
// 8. Wyświetlenie aktywnych wypożyczeń danego użytkownika. 
// 9. Wyświetlenie listy przeterminowanych wypożyczeń.
// 10. Wygenerowanie krótkiego raportu podsumowującego stan wypożyczalni. (DONE)
