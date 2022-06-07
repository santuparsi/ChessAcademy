using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Repositories
{
    public class UserRepository
    {
        static List<User> users = new List<User>()
       {
           new User(){UserId="U0001",Name="Phani",Email="phani@gmail.com",MobileNo="8909898989",Role="Student",Password="12345"}
       };
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public bool Validate(string email,string pwd)
        {
            User user = users.SingleOrDefault(u => u.Email == email && u.Password == pwd);
            if (user != null)
                return true;
            else
                return false;
        }

    }
}
