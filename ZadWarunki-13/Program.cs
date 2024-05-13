using System;

class Kalkulator
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj numer operacji do wykonania:");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        Console.Write("Twój wybór: ");
        int operacja = Convert.ToInt32(Console.ReadLine());

        double wynik = 0;
        switch (operacja)
        {
            case 1:
                wynik = liczba1 + liczba2;
                break;
            case 2:
                wynik = liczba1 - liczba2;
                break;
            case 3:
                wynik = liczba1 * liczba2;
                break;
            case 4:
                
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór operacji!");
                return;
        }

        Console.WriteLine("Twój wynik to: " + wynik);
    }
}