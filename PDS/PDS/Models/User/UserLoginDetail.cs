using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDS.Models.User
{
    public class UserLoginDetail
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public ICollection<UserPersonalDetail> UserPersonalDetails { get; set; }
    }
}