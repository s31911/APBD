# Exceptions

Znajdują się tutaj 2 customowe wyjątki.

1. RentalLimitExceededException -> który jest z założenia rzucany kiedy użytkownik spróbuje wypożyczyć przedmiot który by przekroczył limit (limit jest zapisany w statycznym polu w każdej klasie szczegółowej person).
2. EquipmentUnavailableException -> który jest rzucany gdy ktoś próbuje wypożyczyć przedmiot oznaczony jako niedostępny.