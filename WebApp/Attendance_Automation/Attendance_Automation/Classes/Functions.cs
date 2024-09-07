using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Automation.Classes
{
    public static class Functions
    {

        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnectedtoInternet()
        {
            int description;
            return InternetGetConnectedState(out description, 0);
        }


        public static bool isValidTime(string ts)
        {
            if (ts.Length == 5 && ts.Contains(':'))
            {
                int h;
                int m;

                return int.TryParse(ts.Substring(0, 2), out h) &&
                       int.TryParse(ts.Substring(3, 2), out m) &&
                       h >= 0 && h < 24 &&
                       m >= 0 && m < 60;
            }
            else
            {
                return false;
            }
        }

        public static string GetShamsiMonthFromDate(string FromDate)
        {
            string yearFromDate = FromDate.Substring(0, 4);
            string monthFromDate = FromDate.Substring(5, 2);
            string dayFromDate = FromDate.Substring(8, 2);
            switch (monthFromDate)
            {
                case "01":
                    {
                        return dayFromDate + " " + "فروردین" + " " + yearFromDate;
                    }
                case "02":
                    {
                        return dayFromDate + " " + "اردیبهشت" + " " + yearFromDate;
                    }
                case "03":
                    {
                        return dayFromDate + " " + "خرداد" + " " + yearFromDate;
                    }
                case "04":
                    {
                        return dayFromDate + " " + "تیر" + " " + yearFromDate;
                    }
                case "05":
                    {
                        return dayFromDate + " " + "مرداد" + " " + yearFromDate;
                    }
                case "06":
                    {
                        return dayFromDate + " " + "شهریور" + " " + yearFromDate;
                    }
                case "07":
                    {
                        return dayFromDate + " " + "مهر" + " " + yearFromDate;
                    }
                case "08":
                    {
                        return dayFromDate + " " + "ابان" + " " + yearFromDate;
                    }
                case "09":
                    {
                        return dayFromDate + " " + "اذر" + " " + yearFromDate;
                    }
                case "10":
                    {
                        return dayFromDate + " " + "دی" + " " + yearFromDate;
                    }
                case "11":
                    {
                        return dayFromDate + " " + "بهمن" + " " + yearFromDate;
                    }
                case "12":
                    {
                        return dayFromDate + " " + "اسفند" + " " + yearFromDate;
                    }

                default:
                    return "";

            }

        }

        public static string GetShamsiMonthUntilDate(string UntilDate)
        {
            string yearUntilDate = UntilDate.Substring(0, 4);
            string monthUntilDate = UntilDate.Substring(5, 2);
            string dayUntilDate = UntilDate.Substring(8, 2);
            switch (monthUntilDate)
            {
                case "01":
                    {
                        return dayUntilDate + " " + "فروردین" + " " + yearUntilDate;
                    }
                case "02":
                    {
                        return dayUntilDate + " " + "اردیبهشت" + " " + yearUntilDate;
                    }
                case "03":
                    {
                        return dayUntilDate + " " + "خرداد" + " " + yearUntilDate;
                    }
                case "04":
                    {
                        return dayUntilDate + " " + "تیر" + " " + yearUntilDate;
                    }
                case "05":
                    {
                        return dayUntilDate + " " + "مرداد" + " " + yearUntilDate;
                    }
                case "06":
                    {
                        return dayUntilDate + " " + "شهریور" + " " + yearUntilDate;
                    }
                case "07":
                    {
                        return dayUntilDate + " " + "مهر" + " " + yearUntilDate;
                    }
                case "08":
                    {
                        return dayUntilDate + " " + "ابان" + " " + yearUntilDate;
                    }
                case "09":
                    {
                        return dayUntilDate + " " + "اذر" + " " + yearUntilDate;
                    }
                case "10":
                    {
                        return dayUntilDate + " " + "دی" + " " + yearUntilDate;
                    }
                case "11":
                    {
                        return dayUntilDate + " " + "بهمن" + " " + yearUntilDate;
                    }
                case "12":
                    {
                        return dayUntilDate + " " + "اسفند" + " " + yearUntilDate;
                    }

                default:
                    return "";

            }
        }

    }

    public static class UserAccess
    {
        public static bool? Attendance { get; set; }
        public static bool? Users { get; set; }
        public static bool? Personels { get; set; }
        public static bool? Missions { get; set; }
        public static bool? Leaves { get; set; }
        public static bool? LeavesTime { get; set; }

    }
}
