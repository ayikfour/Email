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
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //ID current user
        int ID = MainForm.Id;
        int ParentID;

        //Variables
        String Subject, Recipient, Message;
        DateTime Created;

        public compose()
        {
            InitializeComponent();            
        }

        public void Reply(String _Recipient, string _ParentID)
        {
            RtbRecipient.Text = _Recipient;
            ParentID = int.Parse(_ParentID);
        }

        public void Draft(String Recipient, String Subject, String Message)
        {
            RtbMessage.Text = Message;
            RtbRecipient.Text = Recipient;
            RtbSubject.Text = Subject;
        }
        
        private void SendMail_Click(object sender, EventArgs e)
        {
            //Method Handling Send Button
            Sent("Sent");
            Flush();
        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            //Method Handling Draft Button
            Sent("Draft");
            Flush();
        }

        private void Sent(String value)
        {
            //Calling GetValue method
            GetValue();

            //Initialize Time
            Created = DateTime.Now;
            
            String Msbox = "";
            String query = "";

            //Initialize Query
            if (value.Equals("Draft"))
            {
                query = "INSERT INTO draft (author_id, sender, recipient, subject, body, created, parent_id) VALUES (@author, @sender, @recipient, @subject, @body, @created, @parent)";
                Msbox = "Added to Draft";
            }
            else
            {
                query = "INSERT INTO outbox (author_id, sender, recipient, subject, body, created, parent_id) VALUES (@author, @sender, @recipient, @subject, @body, @created, @parent)";
                Msbox = "Email has been Sent";
            }
           
            
            try
            {
                //Declaring parameter of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@author", MainForm.Id);
                Command.Parameters.AddWithValue("@sender", MainForm.Email);
                Command.Parameters.AddWithValue("@recipient", Recipient);
                Command.Parameters.AddWithValue("@subject", Subject);
                Command.Parameters.AddWithValue("@body", Message);
                Command.Parameters.AddWithValue("@created", Created);
                Command.Parameters.AddWithValue("@parent", ParentID);

                if (Recipient.Contains('@'))
                {
                    //Opening Connection
                    Connect.Open();
                    Reader = Command.ExecuteReader();

                    //Closing Connection
                    Connect.Close();

                    //Adding to inbox
                    if (value.Equals("Sent"))
                    {
                        AddToInbox();
                    }

                    //Show Message on Success
                    MessageBox.Show(Msbox);
                }
                else
                {
                    MessageBox.Show("Email recipient is not valid");
                }
            }
            catch (Exception ex)
            {
                Connect.Close();

                //Show Message on Fail
                MessageBox.Show(ex.Message);
            }
        }     

        private void AddToInbox()
        {
            //Declaring Query
            String query = "INSERT INTO inbox (author_id, sender, recipient, subject, body, created, parent_id) VALUES (@author, @sender, @recipient, @subject, @body, @created, @parent)";

            //Declaring parameter of the query
            Command = new MySqlCommand(query, Connect);
            Command.Parameters.AddWithValue("@author", MainForm.Id);
            Command.Parameters.AddWithValue("@sender", MainForm.Email);
            Command.Parameters.AddWithValue("@recipient", Recipient);
            Command.Parameters.AddWithValue("@subject", Subject);
            Command.Parameters.AddWithValue("@body", Message);
            Command.Parameters.AddWithValue("@created", Created);
            Command.Parameters.AddWithValue("@parent", ParentID);

            //Opening Connection
            Connect.Open();
            Reader = Command.ExecuteReader();

            //Closing Connection
            Connect.Close();
        }

        private void GetValue()
        {
            //Method to get value on RichTextBox
            this.Subject = RtbSubject.Text;
            this.Recipient = RtbRecipient.Text;
            this.Message = RtbMessage.Text;
        }

        private void Flush()
        {
            //Method to reset value on RichTextBox
            RtbSubject.Text = "";
            RtbRecipient.Text = "";
            RtbMessage.Text = "";
        }
    }
}
