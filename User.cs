using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public User()
        {

        }
        public User(int id, string fullName, string userName, string password, string email, string phoneNumber, string address)
        {
            Id = id;
            FullName = fullName;
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
        public void Display()
        {
            Console.WriteLine($"Ho ten: {FullName}, UserName: {UserName}");
        }
    }
    
}
