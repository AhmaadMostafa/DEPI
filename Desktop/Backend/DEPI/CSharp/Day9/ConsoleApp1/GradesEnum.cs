using System;

namespace ConsoleApp1
{
    enum Grades : short { F = 1, D, C, B, A }

    internal class GradesEnum
    {
        #region Problem 2
            public static void ShowGrades()
            {
                foreach (Grades grade in Enum.GetValues(typeof(Grades)))
                {
                    Console.WriteLine($"{grade} = {(short)grade}");
                }
            }
        #endregion
    }
}
