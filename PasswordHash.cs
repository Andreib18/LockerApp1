using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security;
using System.Data;
using System.Data.SqlClient;

namespace LockerApp1
{
    internal class PasswordHash
    {
       

        public static string HashPassword(User user)
        {
            string pwdToHash = user.Password + "^Y8~JJ";
            string hashToStoreInDatabase = BCrypt.Net.BCrypt.HashPassword(pwdToHash, BCrypt.Net.BCrypt.GenerateSalt());

            SqlConnection sc = new SqlConnection("Data source = .;Initial Catalog = AndreiSQL;Integrated Security = TRUE ");
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("UPDATE TblUsers SET HASH = @parm1 WHERE USERNAME = @parm2", sc);
            da.InsertCommand.Parameters.Add("@parm1", SqlDbType.Char);
            da.InsertCommand.Parameters.Add("@parm2", SqlDbType.VarChar);
            da.InsertCommand.Parameters["@parm1"].Value = hashToStoreInDatabase;
            da.InsertCommand.Parameters["@parm2"].Value = user.Username;
         
            sc.Open();
            da.InsertCommand.ExecuteNonQuery();
            sc.Close();
            return hashToStoreInDatabase;


        }
    }
    }

