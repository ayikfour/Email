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
    public partial class DetailForm : Form
    {
        //Database    
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Variables
        private String _Title, _ID, Action;

        //Parent        
        Mail parent;

        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(String title, int ID, Mail _parent)
        {
            InitializeComponent();

            //Initialize parent
            parent = _parent;


            this._Title = title;            
            this.Title.Text = _Title;
            this._ID = ID.ToString();

            //Setting up component
            SetButtonName(title);
            SetComponent(title);
        }

        private void SetComponent(String table)
        {
            try
            {
                //Declaring Query
                String Query = "SELECT * FROM " + table.ToLower() + " WHERE id=@id";
                Command = new MySqlCommand(Query, Connect);
                Command.Parameters.AddWithValue("@id", _ID);                

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Sender.Text = Reader.GetString(2);
                        Recipient.Text = Reader.GetString(3);
                        Subject.Text = Reader.GetString(4);
                        Body.Text = Reader.GetString(5);
                    }
                }

                //Closing Connection
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (Action.Equals("Reply"))
            {
                ActionForm.Reply(Sender.Text, _ID);
            }
            else if (Action.Equals("Draft") || Action.Equals("Forward"))
            {
                ActionForm.Draft(Recipient.Text, Subject.Text, Body.Text);
            }
            ActionForm.Visible = true;
        }

        private void SetButtonName(String name)
        {
            if (name.ToLower().Equals("inbox"))
            {
                BtnAction.Text = "Reply";
                this.Action = "Reply";
            }
            else if (name.ToLower().Equals("outbox"))
            {
                BtnAction.Text = "Forward";
                this.Action = "Forward";
            }
            else if (name.ToLower().Equals("draft"))
            {
                BtnAction.Text = "Send";
                this.Action = "Send";
            }
            else
            {
                BtnAction.Text = "Restore";
                this.Action = "Restore";
            }
        }
    }
}
