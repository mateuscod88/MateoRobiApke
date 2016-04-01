using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.HelpClass;
namespace DSPWarsztat.Model
{
    public class LogModel : Notify
    {
        private string _login;
        private string _pass;
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if (_login != value)
                    _login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get
            {
                return _pass;
            }
            set
            {
                if (_pass != value)
                    _pass = value;
                OnPropertyChanged("Password");
            }

        }
        public LogModel()
        {
            Login = "m";
            Password = "m";
        }
        
    }
}
