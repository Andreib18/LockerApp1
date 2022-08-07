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
            PasswordTb.PasswordChar = '*';

        }



        public void SaveButton_Click(object sender, EventArgs e)
        {

            User user = new User(UsernameTb.Text, PasswordTb.Text);
           
            bool userExists = DatabaseConnector.CheckUserExists(UsernameTb.Text);
            if (!userExists)
            {
                DatabaseConnector.InsertUser(user);
                PasswordHash.HashPassword(user);
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
                
                    MessageBox.Show("User logged in successfully");
                
            }
            else
            {
                MessageBox.Show("Username or password does not match");

            }
        }
    }
}