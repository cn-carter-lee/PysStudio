using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Pys.Utility
{
    public class PysHtml
    {
        public static string ParseHtml(string htmlText)
        {
            string strNoHtml = Regex.Replace(htmlText, "<[^>]+>", "");
            strNoHtml = Regex.Replace(strNoHtml, "&[^;]+;", "");
            return strNoHtml;
        }
    }
}
