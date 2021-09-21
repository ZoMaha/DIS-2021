using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    abstract class User
    {
        public string login;
        //User() { }
        //static Lazy<User> user = new Lazy<User>( () => new User());
        protected abstract void ShowSession();
    }
}
