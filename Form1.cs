using System.Data.SqlClient;
using System;
using System.ComponentModel;
namespace LockerApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        
        public void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\users\\" +UsernameTb.Text+ ".txt"); //path to write .txt files
            sw.WriteLine(UsernameLb.Text + ": " + UsernameTb.Text);
            sw.WriteLine(PasswordLb.Text + ": " + PasswordTb.Text);
            sw.Close();
            User user = new User(UsernameTb.Text, PasswordTb.Text);
            Authenticator.CheckIfUserExists(user);
            
            bool userExists = DatabaseConnector.CheckUserExists(UsernameTb.Text);
            if (!userExists)
            {
                DatabaseConnector.InsertUser(user);
            }
            else
            {
                MessageBox.Show("Username already exists");
            }
             
            //SqlConnection sc = new SqlConnection("Data source=localhost;Initial Catalog = AndreiSQL;Integrated Security = TRUE ");
            //sc.Open();
            //MessageBox.Show(sc.State.ToString());
            //sc.Close();







        }

        public static implicit operator Form1(bool v)
        {
            throw new NotImplementedException();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            User user = new User(UsernameTb.Text, PasswordTb.Text);
            if (DatabaseConnector.CheckUserCedential(user))
            {
                
                if (DatabaseConnector.CheckUserCedential(user))
                {
                    MessageBox.Show("Login SUCCES");
                }
            }
            else
            {
                MessageBox.Show("Login not SUCCES");

            }
        }
    }
}