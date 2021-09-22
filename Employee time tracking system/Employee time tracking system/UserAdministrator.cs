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
        static Lazy<UserAdministrator> objectUser = new Lazy<UserAdministrator>(() => new UserAdministrator());
        public static UserAdministrator ObjectUser
        {
            get
            {
                return objectUser.Value;
            }
        }

        protected override void ShowSession()
        {

        }
    }
}
