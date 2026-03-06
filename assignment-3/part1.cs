using System.Diagnostics;
using System.Text;

namespace Assignment_3 {
    public class part1
{
    public static void DisplayPart_1()
        {
        

        // a- The code is inefficient because strings are immutable, so 
        // each += creates a new string in memory, causing lots of copying.
        // b-Use StringBuilder to append strings without creating new string
        //  objects each time.
        // c-Use Stopwatch to measure time; concatenation takes much longer 
        // (hundreds of ms) than StringBuilder (few ms).


        // StringBuilder version
        Stopwatch sw2 = Stopwatch.StartNew();

        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= 5000; i++)
        {
            sb.Append(i).Append(",");
        }

        string ids2 = sb.ToString();
        sw2.Stop();
        Console.WriteLine($"StringBuilder time: {sw2.ElapsedMilliseconds} ms");
    }
        }
}