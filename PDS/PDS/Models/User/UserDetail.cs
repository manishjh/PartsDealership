using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDS.Models.User
{
    public class UserDetail
    {
        public UserDetail(UserLoginDetail uld, UserPersonalDetail upd)
        {
            UserID = uld.UserID;
            UserName = uld.UserName;
            Password = uld.Password;
            LastLogin = uld.LastLogin;
            FirstName = upd.FirstName;
            LastName = upd.LastName;
            Address = upd.Address;
            PhoneNum = upd.PhoneNum;
        }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }

    }
}