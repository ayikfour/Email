using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;

namespace Email
{
    public partial class Mail : Form 
    {
        private MainForm main;
        public Mail(MainForm parent)
        {
            InitializeComponent();
            main = parent;
            CurrentUser.Text = MainForm.Email;
        }

        private void BtnCompose_Click(object sender, EventArgs e)
        {
            compose1.BringToFront();

        }

        private void BtnInbox_Click(object sender, EventArgs e)
        {
            inbox1.BringToFront();
            inbox1.UpdateInbox();
        }

        private void BtnSent_Click(object sender, EventArgs e)
        {
            sent1.BringToFront();

        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            draft1.BringToFront();

        }

        private void BtnBin_Click(object sender, EventArgs e)
        {
            bin1.BringToFront();

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            main.Show();
            main.FlushData();
            this.Close();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            main.Show();
            main.FlushData();            
            this.Close();
        }
    }
}
