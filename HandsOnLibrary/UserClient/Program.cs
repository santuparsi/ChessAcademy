using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService;
using UserService.Repositories;
namespace UserClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            User user = new User()
            {
                UserId = "U0002",
                Name = "Rakesh",
                Email = "rakesh@gmail.com",
                MobileNo = "9890989090",
                Role = "Admin",
                Password="12345"
            };
            userRepository.AddUser(user);
            if (userRepository.Validate("phani@gmail.com", "1234"))
            {
                Console.WriteLine("Valid User");
            }
            else
                Console.WriteLine("Invalid user");
            Console.ReadKey();
        }
    }
}
