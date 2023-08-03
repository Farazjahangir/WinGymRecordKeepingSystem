using System;
using System.Collections.Generic;
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
    }
}
