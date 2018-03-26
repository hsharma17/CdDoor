using CDModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace CDDAL
{
    public class DALAccount
    {
        public int Register(RegisterBindingModel obj)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CDConnection"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(DALObjectsEnum.SPRegisterUser, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@FullName", SqlDbType.VarChar, 50, "FullName"));
            command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 50, "UserName"));
            command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50, "Password"));
            command.Parameters.Add(new SqlParameter("@Role", SqlDbType.VarChar, 50, "Role"));

            command.Parameters[0].Value = obj.FullName;
            command.Parameters[1].Value = obj.Email;
            command.Parameters[2].Value = obj.Password;
            command.Parameters[3].Value = "Tenant";

            int i = command.ExecuteNonQuery();

            return i;
        
        }

        public string Login(LoginBindingModel obj)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CDConnection"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand("Login2SP", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar, 50, "UserName"));
            command.Parameters[0].Value = obj.Email;

            command.Parameters.Add("@Password", SqlDbType.VarChar,50).Direction = ParameterDirection.Output;
           

            command.ExecuteNonQuery();
            string value= command.Parameters["@Password"].Value.ToString();


            if (value.Equals(obj.Password))
                return "login successful";
            else
                return "Email or Password incorrect";

        }


    }
}
