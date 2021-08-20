using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    static class MyExtention
    {
        public static string PrintFullName(this Student student)
        {
            return student.FirstName + " " + student.LastName;
        }

        //public static void Print(this DateTime dateTime)
        //{
        //    Console.WriteLine(dateTime);
        //}

        //public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        //{
        //    return dateTime.DayOfWeek == dayOfWeek;
        //}
    }
}
