using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInt
{
    internal interface IAccount
    {
        bool Passwordchecker(string password);
        void ShowInfo();
    }
}
