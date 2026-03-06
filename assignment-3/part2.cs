
using System.Diagnostics;
using System.Text;

namespace Assignment_3 {
    public class part2
{
    public static void DisplayPart_2()
        {
        Console.Write("Enter age: ");
        string ageInput = Console.ReadLine() ?? "";
         if (ageInput == "")
        {
        Console.WriteLine("You do not set Age so we chose 1 Year");
        ageInput = "1";
        }
        int.TryParse( ageInput , out int age);

        Console.Write("Enter day of week (1=Sun, ..., 6=Fri, 7=Sat): ");

        string dayInput = Console.ReadLine() ?? "";
        if (dayInput == "")
        {
        Console.WriteLine("You do not select aday so we chose 1=sun");
        dayInput = "1";
        }
        int.TryParse( dayInput , out int day);
        

        Console.Write("Do you have a student ID? (yes/no): ");
        string studentInput = Console.ReadLine()?.ToLower() ?? "";
        bool isStudent = studentInput == "yes";

        decimal price = 0;
        string breakdown = "";

        if (age < 5)
        {
            price = 0;
            breakdown += "Age < 5: Free\n";
        }
        else if (age <= 12)
        {
            price = 30;
            breakdown += "Age 5-12: 30 LE\n";
        }
        else if (age <= 59)
        {
            price = 50;
            breakdown += "Age 13-59: 50 LE\n";
        }
        else 
        {
            price = 25;
            breakdown += "Age 60+: 25 LE\n";
        }

        if (day == 6 || day == 7)
        {
            if (price > 0)
            {
                price += 10;
                breakdown += "Weekend surcharge: +10 LE\n";
            }
            else
            {
                breakdown += "Weekend surcharge: not applied (ticket is free)\n";
            }
        }

        if (isStudent && price > 0)
        {
            decimal discount = price * 0.2m;
            price -= discount;
            breakdown += $"Student discount (20%): -{discount} LE\n";
        }

        breakdown += $"Final price: {price} LE";
        Console.WriteLine("\n--- Ticket Price Breakdown ---");
        Console.WriteLine(breakdown);
    }
        }
}