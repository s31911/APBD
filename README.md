# ABPD Zad1 Aplikacja konsolowa wypożyczalni sprzętu IT
## Wstęp
Jest to prosta aplikacja konsolowa napisana w C#, .NET w wersji 10.
Apliakcję uruchamiamy przez uruchomienie funkcji  Main w pliku Program.cs
Poszerzyłem podstawowe wymagania o menu tekstowe oraz funkcję zapisu i odczytywania stanu aplikacji z pliku.
> [!WARNING]
> Aplikacja tuż po starcie spróbuje wczytać dane z pliku. Jeżeli się to nie uda aplikajca wyświetli powód niepowodzenia i przejdzie po 3 sekundach automatycznie przejdzie do menu.
> [!TIP]
> Dla wygodnego użytkownia polecam rozwinąć konsole na jak największą część ekranu najlepiej jeszcze przed lub bezpośrednio po uruchomieniu.
## Decyzje projektowe
Aplikacje dla spełnienia wymogów biznesowych zdecydowałem się podzielić na 4 główne cześci:
* persons - inaczej użytkowników
* rentals - wyposażenie do wypożyczenia
* rental - faktyczną instancję wypożyczenia
* UI - menu tekstowe
Pierwsze 3 zbudowane są według schematu klas poniżej (schemat nie uwzględnia metod zawartych w klasach)




Szczegółowe informacje znajdują się w odpowiednich linkach poniżej.
## Linki


