namespace Assignment_3
{
    public class part4
    {
        public static void DisplayPart_4()
        {
            int tempreture = 35;
            string weatherAdvice =
            tempreture < 0 ?  "Freezing Stay in Door"
             : tempreture < 15 ?  "Cold Wear A jacet"
              : tempreture < 25 ?  "Pleasent Weather"
               : tempreture < 35 ?  "Worm stay Hydreated"
               : "Hot Avoid Sun";
            Console.WriteLine(weatherAdvice);
            //For few conditions, ternary is compact and readable.
            // For many conditions or complex logic, nested ternary becomes hard to read.
            // When to choose:
            // Ternary: simple, inline assignments (like pricing, small choices).
            // If-else: complex logic, multiple statements per branch, easier to maintain.
        }
    }
}