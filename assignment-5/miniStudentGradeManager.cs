namespace Assignment_5
{
    public class miniStudentGradeManager
    {
        public static Grade GetGrade(int score)
    {
        if (score >= 90) return Grade.A;
        else if (score >= 80) return Grade.B;
        else if (score >= 70) return Grade.C;
        else if (score >= 60) return Grade.D;
        else return Grade.F;
    }
    public static double CalculateAverage(int[] scores)
    {
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return (double)sum / scores.Length;
    }
    public  static void GetMinMax(int[] scores, out int min, out int max)
    {
        min = scores[0];
        max = scores[0];

        foreach (int score in scores)
        {
            if (score < min) min = score;
            if (score > max) max = score;
        }
    }
    }
}