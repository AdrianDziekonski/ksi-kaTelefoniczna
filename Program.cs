using System;

namespace KsiązkaTelefoniczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam w książce telefonicznej");

            Console.WriteLine("1 Dodaj kontakt");
            Console.WriteLine("2 Wyświetl kontakt po numerze");
            Console.WriteLine("3 Wyświetl wszytskie kontakty");
            Console.WriteLine("4 Szukaj kontaktu");
            Console.WriteLine("x zamknij program");

            var userInput = Console.ReadLine();
            var ksiązkaTelefoniczna = new ClassKsiazkaTelefoniczna();

            while (true)
            {
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("Wpisz numer");
                        var numer = Console.ReadLine();
                        Console.WriteLine("Wpisz nazwę");
                        var nazwa = Console.ReadLine();

                        var nowyKontakt = new Kontakt(nazwa, numer);

                        ksiązkaTelefoniczna.AddContact(nowyKontakt);

                        break;
                    case "2":
                        Console.WriteLine("Wpisz numer");
                        var poszukiwanyNumer=Console.ReadLine();

                        ksiązkaTelefoniczna.DisplayContact(poszukiwanyNumer);

                        break;
                    case "3":
                        ksiązkaTelefoniczna.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Wpisz nazwę");
                        var szukanaFraza=Console.ReadLine();

                        ksiązkaTelefoniczna.DisplayMatchingContacts(szukanaFraza);
                        break;
                         case "x":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowe działanie");
                        break;
                   
                }
                Console.WriteLine("Wybierz operację");
                userInput = Console.ReadLine();
            }
            

        }
    }
}

