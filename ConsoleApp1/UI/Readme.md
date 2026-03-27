# UI
Ui jest podzielone na 2 czesci UiHandler i Commands.
Handler wyświetla menu główne i odpala odpowiednią komendę (z commands) według users input.
### Comment
O ile sam handler i koncept włączania komend, gdzie każda jest swoją osobną klasą nie jest zła, o tyle z perspektywy czasu osadzenie komend na zwykłym switchu nie było najlepszym wyborem. Dużo lepsze byłoby stworzenie centralnej klasy która obsługiwałaby user input i przekazywała go do odpowiedniej komendy na podstawie jej sygnatury. 

Przykładowo wymagamy od komendy żeby posiadała syganture w stylu
{komenda opcja1 opcja2} i taka centralna klasa na podstawie regexa decydowałaby która komendę wykonać i przekazywała user input w postaci dictionary opcja1=>(value).

Zaletą takiego rozwiązania byłoby na pewno to, że nie trzebaby w każdej komendzie pisac switcha na rozczytywania inputa i radzić sobie z błędnymi inputami. 