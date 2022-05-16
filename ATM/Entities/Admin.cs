using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interface;

namespace ATM.Entities
{
    public class Admin : IAdmin
    {
        private string username;
        private string password;
        public static List<Admin> Admins = new List<Admin>();

        public string Username { get => username; }
        public string Password { get => password; }

        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User addUser(string name, string accountBalance, string currency)
        {
            User user = new User(name, accountBalance, currency);

            user.GhiFileID();
            User.GhiFileTheTu();
            user.GhiFileLichSuID();

            return user;
        }

        public bool removeUser(string id)
        {
            if (User.Users.Remove(User.Users.Find(item => item.Id == id)))
            {
                User.Users.Find(item => item.Id == id).XoaFileID();
                return true;
            }
            throw new Exception("Khong tim thay User");
        }

        public bool unlockUser(string id)
        {
            User user;
            if ((user = User.Users.Find(item => item.Id == id)) != null)
            {
                user.Status = StatusUser.Default;
                return true;
            }
            throw new Exception("Khong tim thay User");
        }

        public bool lockUser(string id)
        {
            User user;
            if ((user = User.Users.Find(item => item.Id == id)) != null)
            {
                user.Status = StatusUser.Lock;
                return true;
            }
            throw new Exception("Khong tim thay User");
        }

        public string showUser(string id)
        {
            User user;
            if ((user = User.Users.Find(item => item.Id == id)) != null)
            {
                return user.ToString();
            }
            throw new Exception("Khong tim thay User");
        }
    }
}
