using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils.Extensions
{
    public static class DictionaryExtensions
    {
        public static String ToQueryString(this IDictionary<String, String> values)
        {
            return String.Join("&", values.Select(x => $"{x.Key}={x.Value}"));
        }
    }
}
