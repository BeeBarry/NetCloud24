using System;

class Exercises
{
    public static void EvenOrOdd()
    {
        Console.WriteLine("Var vänlig skriv in ett nummer så tar jag reda på om det är jämn delbart eller ojämnt");
        int number = Int32.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Talet är jämnt");
        }
        else
        {
            Console.WriteLine("Talet är icke jämnt");
        }
    }

    public static void AgeBracket()
    {
        Console.WriteLine("Skriv in din ålder så säger jag dig vilken ålderskategori du befinner dig i");
        int age = Int32.Parse(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("Du är är ett barn!");
        } 
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Du är en ungdom!");   
        }
        else
        {
            Console.WriteLine("Du är en vuxen");
        }
    }

    public static void TestScore()
    {
        Console.WriteLine("Skriv in ditt totala poäng(0-100) så skall jag ge dig ett betyg!");
        int points;

        while (!int.TryParse(Console.ReadLine(), out points) || points < 0 || points > 100)
        {
            Console.WriteLine("Nu blev det fel, säkerställ att poängen är mellan 0-100.");
        }

        string grade;
        
        if (points > 90)
        {
            grade = "A";
        }
        else if (points >= 80)
        {
            grade = "B";
        }
        else if (points >= 70)
        {
            grade = "C";
        } else if (points >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Ditt betyg är...(trumvirvel)... : {grade} ");

    }

    public static void LeapYearChecker()
    {
        Console.WriteLine("Vart det skottår i år? Skriv in ett årtal så listar jag ut ifall det är ett skottår (alltså 366 dagar)");
        
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine($"{year} är ett skottår.");
        }
        else
        {
            Console.WriteLine($"{year} är INTE ett skottår.");
        }
        
    }

    public static void BiggestOfThree()
    {
        Console.WriteLine("Skriv in tre heltal så avgör jag vilken som är högst");
        
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"{num1} är störst!");
        } else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine($"{num2} är störst!");
        }
        else
        {
            Console.WriteLine($"{num3} är störst!");
        }
        
        
    }

    public static void PositiveOrNegative()
    {
        Console.WriteLine("Skriv in ett heltal så säger jag ifall den är glad (positiv), arg (negativ) eller neutral (nolla)");

        int num = Int32.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine($"{num} verkar vara glad :)");
        } else if (num == 0)   
        {
            Console.WriteLine($"{num} verkar vara neutral :| ");
        }
        else
        {
            Console.WriteLine($"{num} verkar vara arg :( ");
        }

    }

    public static void DiscountSystem()
    {
        Console.WriteLine("Handla för 1000kr eller mer och få 10 % i rabatt, skriv in din köpsumma (över 1000kr) så räknar jag ut priset efter rabatten");
        
        double amount = double.Parse(Console.ReadLine());
        double discount;
        double newPrice;

        if (amount >= 1000)
        {
            newPrice = amount * 0.9;
            Console.WriteLine($"Ditt pris efter rabatt blir: {newPrice:F2}.");
        }
        else
        {
            Console.WriteLine("Köpsumman är för låg, du får ingen rabatt!");
        }
        
    }

    public static void Weekdays()
    {
        Console.WriteLine("Skriv in ett heltal mellan 1 till 7, så säger jag vilken veckodag det är!");

        string[] daysOfWeek = { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };
        int dayNumber = int.Parse(Console.ReadLine());
        
        if (dayNumber >=1 && dayNumber <= 7 )
        {
            Console.WriteLine(daysOfWeek[dayNumber -1]);
        }
        else
        {
            Console.WriteLine("Nu blev det fel, skriv in en siffra mellan 1-7");
        }
    }

    public static void PasswordChecker()
    {
        Console.WriteLine("Det finns ett hemligt lösenord, skriv in det så öppnas dörren ;)");

        string password = "CSharp123";
        string input = Console.ReadLine();

        if (input == password)
        {
            Console.WriteLine("Dörren öppnas...");
        }
        else
        {
            Console.WriteLine("Obehöriga äga ej tillträde.");
        }
    }

    public static void TemperatureConverter()
    {
        Console.WriteLine("Välj ett alternativ nedan");
        Console.WriteLine("Tryck 1 för Fahrenheit -> Celsius");
        Console.WriteLine("Tryck 2 för Celsius -> Fahrenheit");
        
        int choice = int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            Console.WriteLine("Skriv in temperaturen in Fahrenheit");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            Console.WriteLine($"{fahrenheit}°F är lika med {celsius:F2}°C");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Skriv in temperaturen in Celsius");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9.0 / 5.0) + 32;
            Console.WriteLine($"{celsius}°C är lika med {fahrenheit}°F");
        }
        else
        {
            Console.WriteLine("Fel inmatning, välj 1 eller 2");
        }
    }
    
}