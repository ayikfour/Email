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
        private DetailForm detail;        

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

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
            sent1.UpdateOutbox();
        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            draft1.BringToFront();
            draft1.UpdateDraft();
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
        
        public void Detail(String title, int ID)
        {
            if(detail == null || detail.IsDisposed)
            {
                detail = new DetailForm(title, ID, this);
                detail.Show();
                this.Hide();
            }
            else
            {
                detail.Show();
                this.Hide();
            }
        }
    }
}
