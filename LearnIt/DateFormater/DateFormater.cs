using System;
using System.Globalization;

namespace LearnIt.DateFormater
{
    public static class DateFormater
    {
        private static CultureInfo ci = new CultureInfo("en-US");

        public static string Format(DateTime d)
           =>  d.ToString("dd MMM yyyy", ci);

        public static string InputStyle(DateTime d)
           => d.ToString("yyyy-MM-dd");
    }
}
