using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class MainForm : Form
    {
        public static Boolean LogedIn = false;
        public static String Email, Pass, Username;
        public static int Id;

        private LoginForm loginform;
        private Mail mailform;
        private RegisterForm registerform;
               
        public MainForm()
        {
            InitializeComponent();                        
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(loginform == null || loginform.IsDisposed)
            {
                loginform = new LoginForm(this);
            }            
            loginform.Show();
            this.Hide();
        }             

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (registerform == null || registerform.IsDisposed)
            {
                registerform = new RegisterForm(this);
            }
            registerform.Show();
            this.Hide();
        }

        public void LaunchMail()
        {
            if (LogedIn)
            {
                if (mailform == null || mailform.IsDisposed)
                {
                    mailform = new Mail(this);
                }                
                mailform.Show();
                this.Hide();
            }            
        }

        public void SetData(String email, String name, String pass, int id) 
        {
            Email = email;
            Username = name;
            Pass = pass;
            Id = id;
        }

        public void FlushData()
        {
            Email = null;
            Username = null;
            Pass = null;
            Id = 0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
