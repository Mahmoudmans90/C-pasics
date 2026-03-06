namespace Assignment_3
{
    public class part6{
        public static void DisplayPart_6(){
            int[] scores = { 95, 82, 47, 66, 38, 74, 89, 91, 55, 33, 60 };
                    Console.WriteLine("Failing scores (<50):");
                    foreach (int score in scores)
                    {
                        if (score < 50)
                            Console.WriteLine(score);
                    }

                    int firstAbove90 = -1;
                    foreach (int score in scores)
                    {
                        if (score > 90)
                        {
                            firstAbove90 = score;
                            break;
                        }
                    }
                    Console.WriteLine($"\nFirst score above 90: {firstAbove90}");

                    int sum = 0;
                    int count = 0;
                    foreach (int score in scores)
                    {
                        if (score >= 40) 
                        {
                            sum += score;
                            count++;
                        }
                    }
                    double average = (count > 0) ? (double)sum / count : 0;
                    Console.WriteLine($"\nClass average (excluding <40): {average:F2}");

                    int a = 0, b = 0, c = 0, d = 0, f = 0;
                    foreach (int score in scores)
                    {
                        if (score >= 90) a++;
                        else if (score >= 80) b++;
                        else if (score >= 70) c++;
                        else if (score >= 60) d++;
                        else f++;
                    }

                    Console.WriteLine("\nGrade distribution:");
                    Console.WriteLine($"A (90-100): {a}");
                    Console.WriteLine($"B (80-89): {b}");
                    Console.WriteLine($"C (70-79): {c}");
                    Console.WriteLine($"D (60-69): {d}");
                    Console.WriteLine($"F (<60): {f}");
        }
    }
}