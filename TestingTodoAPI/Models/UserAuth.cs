using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingTodoAPI.Models
{
    public class UserAuth
    {
        public string username { get; set; }
        public string password { get; set; }

        public UserAuth(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
