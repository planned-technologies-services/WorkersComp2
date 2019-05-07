using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planned.Services
{
    public partial class ApplicationServices
    {
        public override bool UserLogin(string username, string password, bool createPersistentCookie)
        {
            return base.UserLogin(username, password, createPersistentCookie);
        }

    }
}