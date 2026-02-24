using System;

namespace AssignmentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Question1();
            // x => 9هيطبع 9 بسبب explicit casting من double إلى int، وده بيعمل truncation للجزء العشري بدون rounding.
            #endregion

            #region Question 2
            Question2();
            #endregion

            #region Question 3
            Question3();
            #endregion
        
            #region Question 4
            //int.Parse محتاج numeric string فقط، وأي حرف غير رقمي يسبب FormatException.
            #endregion
        
            #region Question 5
            string s = "12a";
            Boolean flag = int.TryParse(s, out int x);
            if (flag)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            #endregion
        
            #region Question 6
            // هيطبع 11 لأن القيمة 10 اتعمل لها boxing داخل object ثم unboxing صحيح إلى int قبل إضافة 1.
            #endregion

            #region Question 7
            //هيعمل InvalidCastException لأن الـ object يحتوي int وميقدرش يتعمله cast مباشر لـ long.
            #endregion

            #region Question 8
            object o = 10;
            // long x = (o is int temp) ? temp : -1;
            if (o is int temp)
            {
                long res = temp;
                Console.WriteLine(res);
            }else
            {
                Console.WriteLine(-1);
            }
            #endregion


            #region Question 9
            //هيطبع سطر فاضي لأن name قيمتها null و?. بيمنع الوصول لـ Length بدون Exception، فيرجع null.
            #endregion
            #region Question 10
            //length will be 0 because name2 is null, and ?.Length with ?? 0 returns 0 instead of throwing an exception.
            #endregion
            #region Question 11
            // The original code only handles null, but throws FormatException if s contains non-numeric text.
            // Use TryParse to safely convert any string to int without exceptions.
            #endregion

            #region Question 12
            // The ! null-forgiving operator tells the compiler: “Trust me, s is not null.”
            // But at runtime, s is actually null, so accessing Length will throw a NullReferenceException.
            //Console.WriteLine(s?.Length ?? 0);
            #endregion

            #region Question 13
            // Convert.ToInt32(null) does not throw an exception like int.Parse does. 
            // It returns 0 when the string is null.
            #endregion
            #region Question 14
            // A: int a = int.Parse(s);
            // s is null → int.Parse(null) throws a ArgumentNullException.
            // The program crashes if you try this.
            // B: int b = Convert.ToInt32(s);
            // s is null → Convert.ToInt32(null) returns 0 safely.
            // No exception occurs, so Console.WriteLine(b); prints: 0
            #endregion

            #region Question 15
            // Console.WriteLine((user ?? "Guest").ToUpper());
            #endregion
        
        }

        #region Question 1 Method
        static void Question1()
        {
            double d = 9.99;
            int x = (int)d;
            Console.WriteLine(x);
        }
        #endregion

        #region Question 2 Method
        static void Question2()
        {
           int n = 5;
           double d2 = n / 2.0;
           d2 = (double)n / 2.0;
           Console.WriteLine(d2);
        }
        #endregion

        #region Question 3 Method
        static void Question3()
        {
            string result =Console.ReadLine()??"";
            int age = int.Parse(result);
        }
        #endregion
    }
}