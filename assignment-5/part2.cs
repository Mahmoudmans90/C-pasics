namespace Assignment_5
{
    public class part2
    {
        public static void displayPart_2_Q1()
         {
        Console.Write("Enter the size of the integer array: ");
        string sizeInput = Console.ReadLine() ?? "";
        if (sizeInput == "")
        {
        Console.Write("Invalid Size !");
        return;
        }
        int.TryParse(sizeInput , out int size);
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element [{i}]: ");
            string iteminput = Console.ReadLine() ??""; 
             int.TryParse(iteminput , out int item);
            numbers[i] = item;
        }

        int sum = 0;
        int max = numbers[0];
        int min = numbers[0];

        for (int i = 0; i < size; i++)
        {
            sum += numbers[i];

            if (numbers[i] > max)
                max = numbers[i];

            if (numbers[i] < min)
                min = numbers[i];
        }

        double average = (double)sum / size;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Maximum Value: {max}");
        Console.WriteLine($"Minimum Value: {min}");

        Console.Write("Array in reverse order: ");
        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine(); 
    }
        

        public static void displayPart_2_Q2()
        {
        const int students = 3;
        const int subjects = 4;

        double[,] grades = new double[students, subjects];

        for (int i = 0; i < students; i++)
        {
            Console.WriteLine($"Enter grades for Student {i + 1}:");

            for (int j = 0; j < subjects; j++)
            {
                Console.Write($"Subject {j + 1}: ");
                string supjectGradeInput = Console.ReadLine() ?? "";
                 double.TryParse(supjectGradeInput , out double grade);
                grades[i, j] = grade;
            }
        }

        double totalSum = 0; 

        Console.WriteLine("Student Averages:");
        for (int i = 0; i < students; i++)
        {
            double sum = 0;

            for (int j = 0; j < subjects; j++)
            {
                sum += grades[i, j];
            }

            double studentAverage = sum / subjects;
            Console.WriteLine($"Student {i + 1} Average: {studentAverage:F2}");

            totalSum += sum; 
        }

        double classAverage = totalSum / (students * subjects);
        Console.WriteLine($"\nOverall Class Average: {classAverage:F2}");
        }
    }
}