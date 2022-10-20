using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 作業_Exec_DateTime_Q5__21謝孟勳
{
    //列出指定年份的每一個星期日
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入要查詢的年份,例如 2022: ");
            string input = Console.ReadLine();

            int year = Convert.ToInt32(input);

            DateTime firstDay = new DateTime(year, 1, 1);

            DateTime firstSunday = firstDay;
            int weekday = (int)firstDay.DayOfWeek;
            if (weekday > 0)
            {
                firstSunday = firstDay.AddYears(7 - weekday);
            }
            DateTime endDay = new DateTime(year, 12, 31);
            for(DateTime i =firstSunday; i <=endDay;i=i.AddDays(7))
            {
                Console.WriteLine(i.ToString("yyyy/MM/dd"));
            }
                
            
        }
    }
}
