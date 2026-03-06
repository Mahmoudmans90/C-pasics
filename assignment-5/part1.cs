namespace Assignment_5
{
    public class part1
    {
        public static void displayPart_1()
        {
        Console.WriteLine("Enter a day number (1-7):");
        string input = Console.ReadLine() ??"";
        int dayNumber;
          

        if (int.TryParse(input, out dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            DayOfWeek day = (DayOfWeek)dayNumber;
            
            Console.WriteLine($"The day is: {day}");

            switch (day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's a Weekend!");
                    break;
                default:
                    Console.WriteLine("It's a Workday!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a number between 0 and 6.");
        }
        }
    }
}