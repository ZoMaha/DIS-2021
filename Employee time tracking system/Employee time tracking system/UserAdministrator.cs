using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    class UserAdministrator: User
    {
        
        UserAdministrator() { }
        static Lazy<UserAdministrator> user = new Lazy<UserAdministrator>(() => new UserAdministrator());

        protected override void ShowSession()
        {

        }
    }
}
