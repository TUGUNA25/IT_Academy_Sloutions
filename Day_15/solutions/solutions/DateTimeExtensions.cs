using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    public static  class DateTimeExtensions
    {

        public static string DayTimeToString(this DateTime input) {
            return  $"{input.Day}/{input.Month}/{input.Year} {input.Hour}:{input.Minute}:{input.Second}:{input.Millisecond}";
        }

        public static bool InRange(this DateTime input, DateTime date1, DateTime date2) { 
            if(input <= date2 && input>= date1)
                return true ;
            else
                return false ;
        }

        public static int YourAge(this DateTime input) { 
            DateTime now = DateTime.Now;
            int answer = now.Year - input.Year;
            if ((now.Month == input.Month && now.Day < input.Day) || now.Month < input.Month)
                answer--;
            return answer;
        }


    }
}
