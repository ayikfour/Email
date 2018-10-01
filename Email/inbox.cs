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
    public partial class inbox : UserControl
    {
        //Database        
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Variables
        int IDinbox;
        int[] IDinboxMultiple;
        Mail ParentMail;
        
        public inbox()
        {
            InitializeComponent();            
            UpdateInbox();
        }

        public void UpdateInbox()
        {
            ListInbox.Items.Clear();

            try
            {
                //Declaring Query
                String query = "SELECT * FROM inbox WHERE recipient=@recipient";

                //Declaring parameters of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@recipient", MainForm.Email);                
                Command.CommandTimeout = 60;

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        String[] row = {
                            Reader.GetString(0),
                            Reader.GetString(2),
                            "Me",
                            Reader.GetString(4),
                            Reader.GetString(5)
                        };
                        var listItems = new ListViewItem(row);
                        ListInbox.Items.Add(listItems);
                    }
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListInbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListInbox.SelectedItems.Count == 0)
            {
                return;
            }
            else if(ListInbox.SelectedItems.Count > 1){
                
            }
            else
            {
                ListViewItem items = ListInbox.SelectedItems[0];
                IDinbox = int.Parse(items.SubItems[0].Text);
            }
                    
        }

        private void ListInbox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ListInbox.Columns[e.ColumnIndex].Width;
        }

        private void ListInbox_DoubleClick(object sender, EventArgs e)
        {
            ParentMail = (Mail)this.Parent;
            ParentMail.Detail("Inbox", IDinbox);
        }
    }
}
