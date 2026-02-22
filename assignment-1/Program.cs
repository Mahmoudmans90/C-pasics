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
            // #region and #endregion are used to collapse/expand sections of code in Visual Studio
            // They help organize large code files into readable sections.
            // Example:

            #region NestedExample
            Console.WriteLine("This is inside a nested region!");
            #endregion
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // Explicit declaration: you specify the type
            int explicitVar = 10;

            // Implicit declaration: compiler infers the type using 'var'
            var implicitVar = "Hello World";

            Console.WriteLine($"Explicit: {explicitVar}, Implicit: {implicitVar}");
            #endregion

            #region Question 3: Constants
            // Constants are values that cannot change after compilation
            const double Pi = 3.14159;
            Console.WriteLine($"Constant Pi = {Pi}");

            // Use constants to prevent accidental changes and improve readability
            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // Class-level variable (accessible by all methods of the class)
            Console.WriteLine($"Class-level field = {classField}");

            void ShowLocalScope()
            {
                // Method-level variable (only accessible inside this method)
                int localVar = 50;
                Console.WriteLine($"Method-level variable = {localVar}");
            }

            ShowLocalScope();

            // localVar is not accessible here, would cause a compile error if uncommented
            // Console.WriteLine(localVar);
            #endregion
        }


    }
}