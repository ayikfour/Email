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
    public partial class bin : UserControl
    {
        //Database        
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Variables
        int IDbin;

        public bin()
        {
            InitializeComponent();
            UpdateBin();
        }

        public void UpdateBin()
        {
            ListBin.Items.Clear();

            try
            {
                //Declaring Query
                String query = "SELECT * FROM bin WHERE author_id=@author";

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
                            Reader.GetString(8),
                            Reader.GetString(3),
                            Reader.GetString(4),
                            Reader.GetString(5)
                        };
                        var listItems = new ListViewItem(row);
                        ListBin.Items.Add(listItems);
                    }
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListBin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBin.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem items = ListBin.SelectedItems[0];
            IDbin = int.Parse(items.SubItems[0].Text);
        }

        private void ListBin_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ListBin.Columns[e.ColumnIndex].Width;
        }
    }
}
