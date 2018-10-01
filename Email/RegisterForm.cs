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
    public partial class RegisterForm : Form
    {
        //Database Connection
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        private String UserName, Email, Password;

        MainForm main;
        public RegisterForm(MainForm parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Register();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Form Can't be Blank");
            }
        }

        private void Register()
        {
            try
            {
                UserName = RegName.Text;
                Email = RegMailName.Text;
                Password = RegPassword.Text;

                //Declaring Query
                String query = "INSERT INTO author (name, mail_name, password) VALUES (@name, @mail, @password)";
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@name", UserName);
                Command.Parameters.AddWithValue("@mail", Email);
                Command.Parameters.AddWithValue("@password", Password);

                //Opening Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                //Closing Connection
                Connect.Close();

                MessageBox.Show("Registration Success!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean CheckForm()
        {
            if(!RegName.Text.Equals("") 
                && !RegMailName.Text.Equals("") 
                && !RegPassword.Text.Equals(""))
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
