using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interface
{
    public interface IUser
    {
        public string autoCreateID();
        public bool GhiFileID();
        public bool GhiFileLichSuID();
        public bool XoaFileID();

    }
}
