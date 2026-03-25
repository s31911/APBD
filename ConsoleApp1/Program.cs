using ConsoleApp1.UI;

namespace ConsoleApp1;
    
using ConsoleApp1.Database;

public class Program
{

    public static AppDatabase AppDatabase = new AppDatabase();
    public static bool exit = false;
    public static void Main()
    {
        UiHandler  uiHandler = new UiHandler();
        while (exit == false)
        {
            uiHandler.handle(Console.ReadLine());
            
        }
        Console.Write("Thank you for using our app.");
    }
    
}


//TODO
// 1. Dodanie nowego użytkownika do systemu.
// 2. Dodanie nowego sprzętu danego typu.
// 3. Wyświetlenie listy całego sprzętu z aktualnym statusem.
// 4. Wyświetlenie wyłącznie sprzętu dostępnego do wypożyczenia.
// 5. Wypożyczenie sprzętu użytkownikowi.
// 6. Zwrot sprzętu wraz z przeliczeniem ewentualnej kary za opóźnienie.
// 7. Oznaczenie sprzętu jako niedostępnego, np. z powodu uszkodzenia lub serwisu.
// 8. Wyświetlenie aktywnych wypożyczeń danego użytkownika.
// 9. Wyświetlenie listy przeterminowanych wypożyczeń.
// 10. Wygenerowanie krótkiego raportu podsumowującego stan wypożyczalni.
// należałoby sie zasntanowić nad zmiana struktur danych (statycznych list) w klasach 