using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    class UserEmployeer : User
    {
        
        UserEmployeer() { }
        static Lazy<UserEmployeer> objectUser = new Lazy<UserEmployeer>(() => new UserEmployeer());
        public static UserEmployeer ObjectUser
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
