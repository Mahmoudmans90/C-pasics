namespace Assignment_5
{
    public class Program
    {
        public static void Main()
        {
            part1.displayPart_1();
            part2.displayPart_2_Q1();
            part2.displayPart_2_Q2();
            part3.displayPart_3_Q_1();
            part3.displayPart_3_Q2(5 );


            // Mini Student Grade 
             const int numStudents = 5;
              int[] scores = new int[numStudents];
      
              for (int i = 0; i < numStudents; i++)
              {
                  Console.Write($"Enter score for student {i + 1}: ");
                  int.TryParse(Console.ReadLine() , out int grade);
                  scores[i] = grade; 
              }
      
              Console.WriteLine("\nStudent Scores and Grades:");
              for (int i = 0; i < numStudents; i++)
              {
                  Grade grade = miniStudentGradeManager.GetGrade(scores[i]);
                  Console.WriteLine($"Student {i + 1}: Score = {scores[i]}, Grade = {grade}");
              }
        }
    }
}