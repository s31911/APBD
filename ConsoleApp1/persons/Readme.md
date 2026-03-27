# Persons

Jest to grupa obiektów o funkcjonalności głównie biznesowej. Są tu obiekty osób które mogą wypożyczyć sprzęt.

W treści zadania wspomniane jest że:

1. Ma być łatwy sposób zmiany limitu wypożyczeń.
2. Jeżeli osoba zwraca po terminie ma być nałożone _jakaś kara_.

Pierwsza rzecz u mnie odbywa się za pośrednictwem funkcji ChangeRentLimit(int nowyLimi).
Druga rzecz Wspominiana _kara_ u mnie polega poprostu na sztucznym podniesieniu obecnie wypożyczonych przez używkownika przedmiotów to efektywnie zmiejsza jego personalny limit wypożyczeń.