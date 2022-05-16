using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interface;

namespace ATM.Entities
{
    public class User : IUser
    {
        private string id;
        private string name;
        private string accountBalance;
        private string currency;
        private string pin;
        private StatusUser status;
        private static int AI = 0;
        public static List<User> Users = new List<User>();

        public string Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string AccountBalance { get => accountBalance; set => accountBalance = value; }
        public string Currency { get => currency; set => currency = value; }
        public string Pin { get => pin; set => pin = value; }
        internal StatusUser Status { get => status; set => status = value; }

        public User(string name, string accountBalance, string currency)
        {
            this.id = autoCreateID();
            this.name = name;
            this.accountBalance = accountBalance;
            this.currency = currency;
            pin = "123456";
            AI++;
            Users.Add(this);
        }
        public static bool GhiFileTheTu()
        {
            return true;
        }

        public string autoCreateID()
        {
            return String.Format("{0:00}", AI) + (2022 + AI + AI / 100) + (2022 - AI + AI / 100) + (1605 + AI + AI / 100);
        }

        public bool GhiFileID()
        {
            throw new NotImplementedException();
        }

        public bool GhiFileLichSuID()
        {
            throw new NotImplementedException();
        }

        public bool XoaFileID()
        {
            throw new NotImplementedException();
        }
    }
}
