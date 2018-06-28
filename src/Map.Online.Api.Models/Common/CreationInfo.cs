using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Online.Api.Models.Common
{
    public interface CreationInfo
    {
        int CreatedBy { get; set;}
         int UpdatedBy { get; set; }
    }
}
