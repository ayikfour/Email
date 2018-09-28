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
        static String ConnectionInfo = "datasource=localhost; port=3306; username=root; password=; database=mail; SslMode=none";
        MySqlConnection Connect = new MySqlConnection(ConnectionInfo);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Variables
        int IDinbox;

        public inbox()
        {
            InitializeComponent();
            UpdateInbox();
        }

        private void ListInbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListInbox.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem items = ListInbox.SelectedItems[0];
            IDinbox = int.Parse(items.SubItems[0].Text);            
        }

        public void UpdateInbox()
        {
            ListInbox.Items.Clear();

            try
            {
                String query = "SELECT * FROM sent WHERE recipient='"+MainForm.Email+"'";
                Command = new MySqlCommand(query, Connect);
                Command.CommandTimeout = 60;
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        String[] row = {
                            Reader.GetString(0),
                            Reader.GetString(1),
                            "Me",
                            Reader.GetString(3),
                            Reader.GetString(4)
                        };
                        var listItems = new ListViewItem(row);
                        ListInbox.Items.Add(listItems);
                    }
                    Connect.Close();
                }             
                Connect.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
