using CDModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDDAL;

namespace CDBAL
{
    public class BALAccount
    {

        public string RegisterUser(RegisterBindingModel obj)
        {
            DALAccount accountObj = new DALAccount();
           int status= accountObj.Register(obj);

           if (status >= 1)
               return "Registration Successfull";
           else
               return "Registration Failed";
        }

        public string LoginUser(LoginBindingModel obj)
        {
            DALAccount accountObj = new DALAccount();
            return accountObj.Login(obj);

        }
    }
}
