using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Email
{
    public partial class compose : UserControl
    {                

        //Database Connection
        static String ConnectionInfo = "datasource=localhost; port=3306; username=root; password=; database=mail; SslMode=none";
        MySqlConnection Connect = new MySqlConnection(ConnectionInfo);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //ID current user
        int ID = MainForm.Id;

        //Variables
        String Subject, Recipient, Message;

        public compose()
        {
            InitializeComponent();            
        }

        public void setCompose(String Recipient, String Subject, String Message)
        {
            RtbMessage.Text = Message;
            RtbRecipient.Text = Recipient;
            RtbSubject.Text = Subject;
        }

        private void SendMail_Click(object sender, EventArgs e)
        {
            Sent();
            Flush();
        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            Draft();
            Flush();
        }

        private void Draft()
        {
            GetValue();
            try
            {
                String query = "INSERT INTO draft (id_user, recipient, subject, message) VALUES ('" + ID+ "', '" + Recipient+ "', '" + Subject+"', '"+Message+ "')";
                Command = new MySqlCommand(query, Connect);
                Connect.Open();
                Reader = Command.ExecuteReader();
                Connect.Close();

                MessageBox.Show("Added to Draft!");
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Sent()
        {
            GetValue();
            try
            {
                String query = "INSERT INTO sent (sender, recipient, subject, message) VALUES ('" + MainForm.Email + "', '" + Recipient + "', '" + Subject + "', '" + Message + "')";
                Command = new MySqlCommand(query, Connect);
                Connect.Open();
                Reader = Command.ExecuteReader();
                Connect.Close();

                MessageBox.Show("Message has been sent!");
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void GetValue()
        {
            this.Subject = RtbSubject.Text;
            this.Recipient = RtbRecipient.Text;
            this.Message = RtbMessage.Text;
        }

        private void Flush()
        {
            RtbSubject.Text = "";
            RtbRecipient.Text = "";
            RtbMessage.Text = "";
        }
    }
}
