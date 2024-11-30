using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskInt
{
    public class User : IAccount
    {
        public string FullName;
        public string Email;
        public string Password;


        public bool Passwordchecker(string password)
        {
            int plenght=password.Length;
            int q = 0, w = 0, e=0;
            string re;
            re = password.ToUpper();
            if (plenght >= 8)
            {
                for (int i = 0; i < plenght; i++)
                {

                    if (password[i] == re[i])
                    {
                        q = 1;

                    }
                    if (password[i] == re[i])
                    {
                        w = 1;

                    }

                    int v = Convert.ToInt32(password[i]);
                    if (password[i] == v)
                    {
                        e = 1;

                    }
                }
                if ((q == 1) || (w == 1) && (e == 1))
                { 
                    return true;
                }
                else
                {
                    Console.WriteLine("Your password in invalid");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Your password in invalid");
                return false;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine(FullName +"\n" + Email);
        }

        
    }
}
