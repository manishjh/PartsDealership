using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PDS.Models.User;
using PDS.Repository;

namespace PDS.Controllers
{
    public class LoginController : ApiController
    {
        private UserRepo repo;
        public LoginController()
        {
            repo = new UserRepo();
        }

        // GET api/login/themanishjha
        [HttpGet]
        public UserDetail Get(string id)
        {
            return repo.getUserDetail(id);
        }

        //GET api/login/
        [HttpGet]
        public List<string> Get()
        {
            return repo.getUsers();
        }
        // POST api/values
        [HttpPost]
        public void Post(UserDetail value)
        {
            repo.AddUser(value);
        }
    }
}
