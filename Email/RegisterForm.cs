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

        static String ConnectionInfo = "datasource=localhost; port=3306; username=root; password=; database=mail; SslMode=none";
        MySqlConnection Connect = new MySqlConnection(ConnectionInfo);
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

                String query = "INSERT INTO user (name, mailName, password) VALUES ('" + UserName+ "', '"+Email+"', '"+Password+"')";
                Command = new MySqlCommand(query, Connect);
                Connect.Open();
                Reader = Command.ExecuteReader();
                Connect.Close();

                MessageBox.Show("Register Success!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean CheckForm()
        {
            if(!RegName.Text.Equals("") && !RegMailName.Text.Equals("") && !RegPassword.Text.Equals(""))
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
