namespace Assignment_5
{
    public class part3
    {
        public  static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        }
        public static void displayPart_3_Q2(double radius)
        {
            Console.Write("Enter the radius of the circle: ");
        string reduseInput = Console.ReadLine() ?? "";
       double.TryParse(reduseInput  , out double radiusIn);
       

        double area, circumference;

        CalculateCircle(radiusIn, out area, out circumference);

        Console.WriteLine($"Area: {area:F2}");
        Console.WriteLine($"Circumference: {circumference:F2}");
            
        }
        public static void displayPart_3_Q_1()
        {    
        Console.Write("Enter the first number: ");
        string num1Input = Console.ReadLine() ?? "";
        double.TryParse(num1Input , out double num1);

        Console.Write("Enter the second number: ");
        string num2input = Console.ReadLine() ?? "";
        double.TryParse(num2input , out double num2 );

        Console.Write("Enter an operation (+, -, *, /): ");
        string op = Console.ReadLine() ?? "";
        if (op == "")
        {
        Console.Write("Enter an operation Next Time!");
        return;
        }

        double result = 0;

        switch (op)
        {
            case "+":
                result = Add(num1, num2);
                break;
            case "-":
                result = Subtract(num1, num2);
                break;
            case "*":
                result = Multiply(num1, num2);
                break;
            case "/":
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation!");
                return;
        }

        if (!double.IsNaN(result))
        {
            Console.WriteLine($"Result: {result}");
        }
        }
        public static double Add(double num1 , double num2)
        {
            return num1+num2;
        }
        public static double Subtract(double num1 , double num2)
        {
            return num1-num2;
        }
        public static double Multiply(double num1 , double num2)
        {
            return num1*num2;
        }
        public static double Divide(double num1 , double num2)
        {
            return num1/num2;
        }
    }
}