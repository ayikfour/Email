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
    public partial class draft : UserControl
    {
        //Database        
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Variables
        int IDdraft;        
        Mail ParentMail;

        public draft()
        {
            InitializeComponent();
            UpdateDraft();
        }

        public void UpdateDraft()
        {
            ListDraft.Items.Clear();

            try
            {
                //Declaring Query
                String query = "SELECT * FROM draft WHERE author_id=@author";

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
                        ListDraft.Items.Add(listItems);
                    }
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListDraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListDraft.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem items = ListDraft.SelectedItems[0];
            IDdraft = int.Parse(items.SubItems[0].Text);
        }

        private void ListDraft_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ListDraft.Columns[e.ColumnIndex].Width;
        }

        private void ListDraft_DoubleClick(object sender, EventArgs e)
        {
            ParentMail = (Mail)this.Parent;
            ParentMail.Detail("Draft", IDdraft);
        }
    }
}
