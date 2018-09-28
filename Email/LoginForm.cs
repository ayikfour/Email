using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Email
{
    public partial class LoginForm : Form
    {
        
        private MainForm main;        
        private String Email, Password, UserName;
        private int ID;

        //Database Connection
        static String ConnectionInfo = "datasource=localhost; port=3306; username=root; password=; database=mail; SslMode=none";
        MySqlConnection Connect = new MySqlConnection(ConnectionInfo);
        MySqlCommand Command;
        MySqlDataReader Reader;

        public LoginForm(MainForm parent)
        {
            InitializeComponent();
            main = parent;            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Auth())
            {
                MainForm.LogedIn = true;
                this.Close();                
                main.LaunchMail();                
            }                
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }
        
        private Boolean Auth()
        {
            Boolean status = false;
            try
            {
                String query = "SELECT * FROM user WHERE mailName='" + LoginUsername.Text.ToLower() + "'";
                Command = new MySqlCommand(query, Connect);
                Connect.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {                    
                    while (Reader.Read())
                    {
                        ID = Reader.GetInt32(0);
                        UserName = Reader.GetString(1);                        
                        Email = Reader.GetString(2);
                        Password = Reader.GetString(3);                        

                        if (Email.Equals(LoginUsername.Text))
                        {
                            if (Password.Equals(LoginPassword.Text))
                            {                                
                                main.SetData(Email, UserName, Password, ID);
                                status = true;                                
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email address not found");
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("Email Address not Found");
                    status = false;
                }
                Connect.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
