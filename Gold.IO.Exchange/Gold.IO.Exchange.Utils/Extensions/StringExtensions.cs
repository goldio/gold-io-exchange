using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Extensions
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }
    }
}
