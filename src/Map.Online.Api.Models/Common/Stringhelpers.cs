using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Common
{
    public static class Stringhelpers
    {
        public static string ConvertDate(string date)
        {
            if (!string.IsNullOrEmpty(date))
            {
                //TODO: Need to convert to standard SI acceptable format
                DateTime oDate = DateTime.Parse(date);
                return String.Format("{0:s}", oDate);
            }
            else
            {
                return "";
            }
        }
    }
}
