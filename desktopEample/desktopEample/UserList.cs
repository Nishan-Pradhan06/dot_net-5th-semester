using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktopEample
{
    public class UserList
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string LoginId { get; set; } = null!;
        public string LoginPassword { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
