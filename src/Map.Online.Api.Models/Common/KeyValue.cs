using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Common
{
    public class KeyValue
    {
        public string Key { get; set; }
        public int Value { get; set; }
    }

    public class RowContent
    {
        public List<string> RowData { get; set; }
        public string[] RowColumnValues { get; set; }
    }
}
