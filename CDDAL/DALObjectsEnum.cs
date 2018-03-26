using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDDAL
{
    public enum StoredProcedure
    {
        Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }  


    public static class DALObjectsEnum
    {
        public static string SPRegisterUser = "SPRegisterUser";
        public static string SPRegisterProperty = "SPRegisterProperty";
        public static string SPRegisterOwner = "SPRegisterOwner";
    }
}
