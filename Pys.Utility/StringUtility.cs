using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pys.Utility
{
    public static class StringOperation
    {
        public static string PysSubString(this string str, int length)
        {
            return str.Length > length ? str.Substring(0, length) + "..." : str;
        }
    }
}
