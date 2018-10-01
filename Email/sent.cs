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
    public partial class sent : UserControl
    {
        //Database        
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Variables
        int IDoutbox;        
        Mail ParentMail;

        public sent()
        {
            InitializeComponent();
            UpdateOutbox();
        }

        public void UpdateOutbox()
        {
            ListOutbox.Items.Clear();

            try
            {
                //Declaring Query
                String query = "SELECT * FROM outbox WHERE author_id=@author";

                //Declaring parameters of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@author", MainForm.Id);                
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
                            Reader.GetString(3),                            
                            Reader.GetString(4),
                            Reader.GetString(5)
                        };
                        var listItems = new ListViewItem(row);
                        ListOutbox.Items.Add(listItems);
                    }
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ListOutbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListOutbox.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem items = ListOutbox.SelectedItems[0];
            IDoutbox = int.Parse(items.SubItems[0].Text);
        }

        private void ListOutbox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ListOutbox.Columns[e.ColumnIndex].Width;
        }

        private void ListOutbox_DoubleClick(object sender, EventArgs e)
        {
            ParentMail = (Mail)this.Parent;
            ParentMail.Detail("Outbox", IDoutbox);
        }
    }
}
