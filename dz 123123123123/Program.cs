using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dz_3._7._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task3
            string pattern = @"^[a-zA-Z0-9_]{1,20}@[a-zA-Z0-9_]{1,20}\.[a-zA-Z]{2,15}$";

            string email = "alex@proton.me";
            if (Regex.IsMatch(email, pattern)) Console.WriteLine($"{email} is OK");
            else Console.WriteLine($"{email} is not OK");

            email = "moyapochta@alex";
            if (Regex.IsMatch(email, pattern)) Console.WriteLine($"{email} is OK");
            else Console.WriteLine($"{email} is not OK");
            #endregion



            #region task4
            string patternn = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$";

            string time = "22:05:55";
            if (Regex.IsMatch(time, patternn)) Console.WriteLine($"{time} is OK");
            else Console.WriteLine($"{time} is not OK");

            time = "25:65:65";
            if (Regex.IsMatch(time, patternn)) Console.WriteLine($"{time} is OK");
            else Console.WriteLine($"{time} is not OK");
            #endregion



            #region task5
            string patternnn = @"^(?:(?:31(?!.(?:0[2469]|11)))|(?:29|30)(?!.(?:02))|(?:0?[1-9]|1\d|2[0-8]))\.(?:(?:0[1-9])|(?:1[0-2]))\.(?:(?:\d{4})(?!0000)|(?:(?<=\d{2})((?:[2468][048])|(?:[13579][26]))))$";
            Regex regex = new Regex(patternnn);

            string date = "26.05.2005";
            if (regex.IsMatch(date)) Console.WriteLine($"{date} is OK");
            else Console.WriteLine($"{date} is dich");

            date = "29.02.2023";
            if (regex.IsMatch(date)) Console.WriteLine($"{date} is OK");
            else Console.WriteLine($"{date} is dich");
            #endregion
        }
    }
}
