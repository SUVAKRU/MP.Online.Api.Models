using Map.Online.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Online.Api.Models.Admin
{
    public class UserDetails : CreationInfo
    {
        public int userId { get; set; }
        public string UserName { get; set; }       
        public string Email { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public int VendorId { get; set; }
        public bool Status { get; set; }
        public bool IsActive { get; set; } 
        public int CreatedBy
        {
            get
            {
                return 0;
            }
            set { value = 0; }
        }

        public int UpdatedBy
        {
            get
            {
                return 0;
            }
            set { value = 0; }
        }
    }
}
