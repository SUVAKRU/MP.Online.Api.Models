using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.FileEngine
{
    public class POFileConfiguration
    {
       public int FieldSeparator { get; set; }
       public bool IsEnclosedWithQuotes { set; get; }
       public int NumberOfColumns { get; set; }

    }
}
