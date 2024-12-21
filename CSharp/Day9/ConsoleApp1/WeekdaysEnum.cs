using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Weekdays { Monday = 1, Tuesday, Wednesday, Thursday, Friday }
    internal class WeekdaysEnum
    {
        #region Problem 1
            public static void DisplayWeekdays()
            {
                foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
                {
                    Console.WriteLine($"{day} = {(int)day}");
                }
            }
        #endregion
    }
}
