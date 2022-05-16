using ATM.Entities;
using System.Collections.Generic;

namespace ATM.Interface
{
    internal interface IAdmin
    {
        public User addUser(string name, string accountBalance, string currency);
        public bool removeUser(string id);
        public bool unlockUser(string id);
        public bool lockUser(string id);
        public string showUser(string id);
    }
}
