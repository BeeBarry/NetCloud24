namespace Interactive_Methods;

public class TestRunner
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        bool isFirstTime = true;

        while (keepRunning)
        {
            if (isFirstTime)
            {
                Console.WriteLine("Tjenare kompis, skriv in en siffra (1-10) så trollar jag fram den. OBS! Tryck 0 ifall du behöver en kaffepaus och vill komma tillbaka senare");
                isFirstTime = false;
            }
            else
            {
                Console.WriteLine("Välj nästa metod (1-10)");
            }
            
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Nu gick det för snabbt, tänk på att skriva in en siffra (1-10)");
            }

            switch (choice)
            {
                case 1:
                    Exercises.EvenOrOdd();
                    break;
                case 2:
                    Exercises.AgeBracket();
                    break;
                case 3:
                    Exercises.TestScore();
                    break;
                case 4:
                    Exercises.LeapYearChecker();
                    break;
                case 5:
                    Exercises.BiggestOfThree();
                    break;
                case 6:
                    Exercises.PositiveOrNegative();
                    break;
                case 7:
                    Exercises.DiscountSystem();
                    break;
                case 8:
                    Exercises.Weekdays();
                    break;
                case 9:
                    Exercises.PasswordChecker();
                    break;
                case 10:
                    Exercises.TemperatureConverter();
                    break;
                case 0:
                    keepRunning = false;
                    Console.WriteLine("Kaffepaus initierad. Programmet avslutas...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt svar, välj en siffra mellan 1-10");
                    break;

                    
                
            }
            
            if (keepRunning)
            {
                Console.WriteLine("-----------------------\n");
            }
        }
        
    }
}