using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");

          

            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //#region و #endregion هما preprocessor directives في C#، يعني أوامر للمترجم تساعدك تنظيم الكود داخل محرر النصوص (مثل Visual Studio)، مش حاجة بتأثر على التشغيل.
            // How it helps in code organization:
            
            // تقدر تجمع كتل الكود الكبيرة تحت عنوان واحد وتضغطها Collapse، بحيث يبقى الملف مرتب.
            
            // تسهّل على المطوّرين قراءة الملفات الكبيرة بسرعة.
            
            // ممتاز لما يكون عندك ملف فيه أكتر من class أو method أو مجموعة functions.
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example
            #region outer
            #region inner
            int any_thing = 546;

            Console.WriteLine(any_thing);
            #endregion
            #endregion
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //explicit =>بتحدد نوع المتغير عند تعريفه.
            //Implicit =>ستخدم var، والمترجم يحدّد نوع المتغير تلقائيًا بناءً على القيمة اللي بتحطها.
            //
            // ══════════════════════════════════════════════════════════════════════

        

            // EXPLICIT DECLARATION 
        
            int age = 25; 
            // IMPLICIT DECLARATION 
           var name = "Alice";
            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //Immutability (القيمة ثابتة):

             // بعد تعريفه، لا يمكن تغيير القيمة طوال فترة البرنامج.
             
             // يضمن عدم تعديل القيم المهمة عن طريق الخطأ.
             
    
             
             // يجعل الكود أسهل للفهم، لأن أي مطور يعرف أن هذه القيمة ثابتة.

             
             // القيم الثابتة عادة يتم استبدالها مباشرة في الكود أثناء الترجمة، لذلك تكون أسرع من المتغيرات العادية.
             
             // لو استخدمت نفس القيمة في أكثر من مكان، يمكن تعديلها في مكان واحد فقط إذا كانت معرفة كـ const
            // ══════════════════════════════════════════════════════════════════════

       

            // Constant examples
           const double Pi = 3.14159;
            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //class-level=>  المتغيرات المعرفة على مستوى الكلاس تكون متاحة لكل الدوال داخل الكلاس.
            //method-level=>  المتغيرات المعرفة داخل دالة تكون متاحة فقط داخل تلك الدالة.
            // ══════════════════════════════════════════════════════════════════════

            static int classField = 100; // Class-level variable
              static void function_name()
                    {
                    int localVar = 50; // Method-level variable
                    }

            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //متغير له block-level scope يعني متاح فقط داخل القوسين {} اللي اتعرف فيه.
            // مفيد لما تحتاج متغير محلي داخل if, for, while أو أي block محدد ولا يجب أن يكون معروفًا خارج هذا block.
            //
            // ══════════════════════════════════════════════════════════════════════
        for (int i = 0; i < 3; i++)
            {
            int loopVar = i * 10; // Loop block variable
            Console.WriteLine($"Inside for loop: {loopVar}");
            }
            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.

            //Variable lifetime هو المدة الزمنية اللي يظل فيها المتغير موجودًا في الذاكرة أثناء تنفيذ البرنامج.
            //Local variable هو أي متغير تم تعريفه داخل دالة أو block.
            // Lifetime: المتغير موجود فقط أثناء تنفيذ الدالة أو block. بمجرد انتهاء الدالة، المتغير يتم حذفه من الذاكرة.
            // ══════════════════════════════════════════════════════════════════════
            // Static variable هو أي متغير تم تعريفه باستخدام الكلمة المفتاحية static.
            // Lifetime: المتغير يبقى موجود طوال فترة تشغيل البرنامج، حتى بعد انتهاء الدالة.
         
            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //Garbage Collector هو نظام إدارة الذاكرة التلقائي في .NET.
            // يبحث عن objects اللي لم يعد هناك أي reference لها.
            // يقوم بتحرير الذاكرة الخاصة بهذه objects تلقائيًا.
            // الهدف: تجنب تسرب الذاكرة (Memory Leak) وتسهيل إدارة الموارد.
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //Variable Shadowing هو عندما تعيد تعريف متغير بنفس الاسم في scope أضيق بحيث “يُظلل” المتغير الأصلي.
            // يعني: لو عندك variable معرف في class أو method، ممكن تعمل variable بنفس الاسم داخل block أصغر (مثل if أو for)، ويصبح هذا الأخير يُستخدم داخل هذا block فقط.
            //             C# يسمح بالshadowing داخل nested blocks داخل نفس method.
            //  لكن لا يمكنك تعريف variable بنفس الاسم في نفس scope (مثل تعريفه مرتين في نفس الدالة بدون block جديد).
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //// 1) Must start with a letter or underscore, 2) Can contain letters, digits, and underscores, 3) Cannot be a C# reserved keyword, 4) Case-sensitive, 5) Should be meaningful
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //// Local variables: camelCase, Class names: PascalCase, Constants: PascalCase or UPPER_CASE
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            // Syntax Error: compile-time, Runtime Error: execution-time, Logical Error: runs but gives wrong result
            //// Syntax Error: int number = 10 // missing semicolon
             // Runtime Error: int a = 10; int b = 0; Console.WriteLine(a / b); // division by zero
             // Logical Error: int sum = 5 - 10; Console.WriteLine(sum); // should be addition
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //// Exception handling prevents crashes,  and logs errors; without it, program may crash and lose data.
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════
        try
        {
            Console.WriteLine("Inside try block");
            int a = 10;
            int b = 0;
            Console.WriteLine(a / b); 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Caught exception: Cannot divide by zero!");
        }
        finally
        {
            Console.WriteLine("Finally block executes regardless of exception.");
        }
            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //// NullReferenceException: occurs when accessing a null object
            // DivideByZeroException: occurs when dividing by zero
            // IndexOutOfRangeException: occurs when accessing an array or list out of bounds
            // InvalidOperationException: occurs when performing an invalid operation on an object in its current state
            // FormatException: occurs when converting a string to an incompatible data type
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //// Catch blocks must be ordered from most specific to most general; otherwise, specific exceptions will never be reached.
            // ══════════════════════════════════════════════════════════════════════
                try
                 {
                     int a = 10;
                     int b = 0;
                     Console.WriteLine(a / b); // causes DivideByZeroException
                 }
                 catch (DivideByZeroException ex)
                 {
                     Console.WriteLine("Caught DivideByZeroException");
                 }
                 catch (ArithmeticException ex)
                 {
                     Console.WriteLine("Caught ArithmeticException");
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Caught general exception");
                 }
            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //// 'throw' preserves the original stack trace (sequence of method calls), 'throw ex' resets it.
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //// Stack stores value types (int, double, structs) and method calls; fast, automatically cleared when method ends
            // Heap stores reference types (objects, arrays, strings); slower, managed by Garbage Collector, exists until no references point to it
            // ══════════════════════════════════════════════════════════════════════

          
            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════
            // Value Type Example
             int x = 10;
             int y = x;   // copy value
             y = 20; //x=10

             // Reference Type Example
            int[] arr1 = {1, 2, 3};
            int[] arr2 = arr1; // copy reference
            arr2[0] = 100; //arr1[0] =100
            #endregion

            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //// 'object' is the base type of all types in C#; every type (value or reference) derives from System.Object
             // Methods inherited by all types include: ToString(), Equals(), GetHashCode(), GetType(), and Finalize()
            // ══════════════════════════════════════════════════════════════════════

            #endregion

        }

        
        #endregion
    }

    
}