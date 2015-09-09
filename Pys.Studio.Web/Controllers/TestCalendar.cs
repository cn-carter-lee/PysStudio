using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pys.Studio.Web.Controllers
{
    public class TestCalendar
    {
        private DateTime _pointDateTime;
        private DateTime _startDateTime;

        public DateTime PointDateTime { get { return _pointDateTime; } }

        public DateTime StartDateTime { get { return _startDateTime; } }

        public TestCalendar()
        {
            _pointDateTime = DateTime.Now;
        }

        public TestCalendar(DateTime pointDateTime)
        {
            _pointDateTime = pointDateTime;
        }

        private void GetStartDate()
        {
            DateTime startDateTimeOfMonth = _pointDateTime.AddDays(1 - _pointDateTime.Day);
            _startDateTime = startDateTimeOfMonth.AddDays(-(int)startDateTimeOfMonth.DayOfWeek);
        }

        public string Generate()
        {
            GetStartDate();
            StringBuilder stringResult = new StringBuilder();
            stringResult.AppendLine("<table class=\"pyscalendar\" cellpadding=\"0\" cellspacing=\"1\">");
            stringResult.AppendLine("<tr><th>日</th><th>一</th><th>二</th><th>三</th><th>四</th><th>五</th><th>六</th></tr>");
            for (int i = 0; i < 42; i++)
            {
                if (i % 7 == 0)
                {
                    stringResult.AppendLine("<tr>");
                }
                DateTime tempDateTime = _startDateTime.AddDays(i);
                if (tempDateTime.DayOfYear == DateTime.Now.DayOfYear)
                {
                    stringResult.AppendLine(string.Format("<td class=\"today\">{0}</td>", tempDateTime.Day));
                }
                else
                {
                    stringResult.AppendLine(string.Format("<td>{0}</td>", tempDateTime.Day));
                }
                if (i > 0 && i % 7 == 6)
                {
                    stringResult.AppendLine("</tr>");
                }
            }
            stringResult.AppendLine("</table>");
            return stringResult.ToString();
        }
    }
}
