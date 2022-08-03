using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerApp1
{
    internal static class Authenticator
    {
        
         public static bool CheckIfUserExists(User user)
        {
            bool usernameExists = Directory.EnumerateFiles(@"C:\Users\work\source\repos\LockerApp1\bin\Debug\net6.0-windows\users", ".txt").Contains("~"+ user.Username + "~");
            if (usernameExists == true)
            {
                return true;
            }
            else
            {
               
                return false;
            }
            
        }

    }
}
