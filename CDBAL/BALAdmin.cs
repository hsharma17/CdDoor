using CDModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDDAL;

namespace CDBAL
{
    public class BALAdmin
    {
        public string RegisterProperty(submitNewProperty obj)
        {
            
            DALAdmin objAdmin = new DALAdmin();
           return objAdmin.RegisterProperty(obj);
            
        }
    }
}
