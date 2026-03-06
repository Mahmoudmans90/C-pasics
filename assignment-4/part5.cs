namespace Assignment_4
{
    public class part5
    {
        public static void DisplayPart_5()
        {
              int attempts = 0;
              bool isValid = false;

        do
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine() ?? "";
            attempts++;

            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpace = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsDigit(c)) hasDigit = true;
                if (char.IsWhiteSpace(c)) hasSpace = true;
            }

            if (password.Length < 8 || !hasUpper || !hasDigit || hasSpace)
            {
                Console.WriteLine("Password invalid due to:");
                if (password.Length < 8) Console.WriteLine("- Less than 8 characters");
                if (!hasUpper) Console.WriteLine("- No uppercase letter");
                if (!hasDigit) Console.WriteLine("- No digit");
                if (hasSpace) Console.WriteLine("- Contains spaces");

                if (attempts >= 5)
                {
                    Console.WriteLine("Account locked");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Password accepted!");
                isValid = true;
            }

        } while (!isValid && attempts < 5);
    }
    }
}