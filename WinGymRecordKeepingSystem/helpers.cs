using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGymRecordKeepingSystem
{
    public static class Helpers
    {
        public static string removeDashesFromString(string text)
        {
            return text.Replace("-", "").Trim();
        }

        public static DateTimeOffset convertDateTimeToLocal(DateTimeOffset date)
        {
            DateTimeOffset dateTime = date;
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            return TimeZoneInfo.ConvertTime(dateTime, localTimeZone);
        }

        public static DataTable setDateTimeInDataTableToCurrent(DataTable dt, string columnName)
        {
            foreach (DataRow row in dt.Rows)
            {
              DateTimeOffset dateTime = (DateTimeOffset)row[columnName];
             row[columnName] = convertDateTimeToLocal(dateTime);
            }

            return dt;
        }
    }
}
