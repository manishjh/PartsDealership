using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PDS.Models.User;

namespace PDS.Repository
{
    public class UserRepo
    {
        UserContext usrContxt = new UserContext();

        public UserRepo()
        {

        }

        public UserDetail getUserDetail(string userName)
        {
            var loginInfo = usrContxt.UserLoginDetails.ToList().Find(x => x.UserName == userName);
            var personalInfo = usrContxt.UserPersonalDetails.ToList().Find(x => x.UserID == loginInfo.UserID);
            return new UserDetail(loginInfo,personalInfo);
        }

        public List<string> getUsers()
        {
            return usrContxt.UserPersonalDetails.ToList().Select(x=>x.FirstName + " " + x.LastName).ToList();
        }

        public void AddUser(UserDetail user)
        {
            usrContxt.UserLoginDetails.Add(new UserLoginDetail()
            {
                UserID = user.UserID,
                UserName = user.UserName,
                Password = user.Password,
                LastLogin=user.LastLogin,
            }   );
            usrContxt.UserPersonalDetails.Add(new UserPersonalDetail()
            {
                FirstName=user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                PhoneNum=user.PhoneNum,
                UserID = user.UserID
            }
                );
        }


    }
}