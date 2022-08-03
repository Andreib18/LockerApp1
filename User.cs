using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerApp1
{
    internal class User
    {
        
        private string _username;
        private string _password;

        public User(string username,string password)
        {
            _username = username;
            _password = password;
        }
        public string Username
        {
            get { return _username; }
             set
            {
                if (value == "")
                {
                    throw new ArgumentException("Invalid name");
                    
                }
                
                else
                {
                    _username = value;
                }
            }
        }
        
        
        

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password == "")
                {
                    throw new ArgumentException("Invalid password");
                }
                else
                {
                    _password = value;
                }
            }
        }

    }
}
