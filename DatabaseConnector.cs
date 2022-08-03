using System.Data.SqlClient;
using System.Data;
namespace LockerApp1
{
    internal class DatabaseConnector
    {



        public static void InsertUser(User user)
        {
            SqlConnection sc = new SqlConnection("Data source = .;Initial Catalog = AndreiSQL;Integrated Security = TRUE ");
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO tblUsers VALUES (@USERNAME,@PASSWORD)", sc);
            da.InsertCommand.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = user.Username;
            da.InsertCommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = user.Password;
            sc.Open();
            da.InsertCommand.ExecuteNonQuery();
            sc.Close();
        }
        public static bool CheckUserExists(string username)
        {
            SqlConnection sc = new SqlConnection("Data source = .;Initial Catalog = AndreiSQL;Integrated Security = TRUE ");
            SqlCommand selectCommand = new SqlCommand("Select count(username) from tblUsers where username = @username", sc);
            selectCommand.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username;

            sc.Open();
            var userCount = (Int32)selectCommand.ExecuteScalar();
            sc.Close();
            return userCount > 0;

        }
        public static bool CheckUserCedential(User user)
        {

            SqlConnection sc = new SqlConnection("Data source = .;Initial Catalog = AndreiSQL;Integrated Security = TRUE ");
            SqlCommand selectCommand = new SqlCommand("Select count(username) from tblUsers where username = @username and password =@password", sc);
            selectCommand.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = user.Username;
            selectCommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = user.Password;
            sc.Open();
            var userCount = (Int32)selectCommand.ExecuteScalar();
            sc.Close();
            if (userCount ==1)
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
    
