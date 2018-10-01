namespace Email
{
    partial class Mail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnBin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDraft = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnInbox = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCompose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.compose1 = new Email.compose();
            this.sent1 = new Email.sent();
            this.inbox1 = new Email.inbox();
            this.draft1 = new Email.draft();
            this.bin1 = new Email.bin();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnBin);
            this.panel1.Controls.Add(this.BtnDraft);
            this.panel1.Controls.Add(this.BtnSent);
            this.panel1.Controls.Add(this.BtnInbox);
            this.panel1.Controls.Add(this.BtnCompose);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 450);
            this.panel1.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Muli ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(0, 408);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(176, 42);
            this.BtnLogout.TabIndex = 7;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnBin
            // 
            this.BtnBin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnBin.BackColor = System.Drawing.Color.Transparent;
            this.BtnBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBin.BorderRadius = 0;
            this.BtnBin.ButtonText = "   Bin";
            this.BtnBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnBin.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnBin.Iconimage")));
            this.BtnBin.Iconimage_right = null;
            this.BtnBin.Iconimage_right_Selected = null;
            this.BtnBin.Iconimage_Selected = null;
            this.BtnBin.IconMarginLeft = 15;
            this.BtnBin.IconMarginRight = 0;
            this.BtnBin.IconRightVisible = true;
            this.BtnBin.IconRightZoom = 0D;
            this.BtnBin.IconVisible = true;
            this.BtnBin.IconZoom = 30D;
            this.BtnBin.IsTab = true;
            this.BtnBin.Location = new System.Drawing.Point(0, 257);
            this.BtnBin.Margin = new System.Windows.Forms.Padding(17, 2, 2, 2);
            this.BtnBin.Name = "BtnBin";
            this.BtnBin.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnBin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.BtnBin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBin.selected = false;
            this.BtnBin.Size = new System.Drawing.Size(176, 51);
            this.BtnBin.TabIndex = 5;
            this.BtnBin.Text = "   Bin";
            this.BtnBin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBin.Textcolor = System.Drawing.Color.White;
            this.BtnBin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBin.Click += new System.EventHandler(this.BtnBin_Click);
            // 
            // BtnDraft
            // 
            this.BtnDraft.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnDraft.BackColor = System.Drawing.Color.Transparent;
            this.BtnDraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDraft.BorderRadius = 0;
            this.BtnDraft.ButtonText = "   Draft";
            this.BtnDraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDraft.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraft.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDraft.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDraft.Iconimage")));
            this.BtnDraft.Iconimage_right = null;
            this.BtnDraft.Iconimage_right_Selected = null;
            this.BtnDraft.Iconimage_Selected = null;
            this.BtnDraft.IconMarginLeft = 15;
            this.BtnDraft.IconMarginRight = 0;
            this.BtnDraft.IconRightVisible = true;
            this.BtnDraft.IconRightZoom = 0D;
            this.BtnDraft.IconVisible = true;
            this.BtnDraft.IconZoom = 30D;
            this.BtnDraft.IsTab = true;
            this.BtnDraft.Location = new System.Drawing.Point(0, 206);
            this.BtnDraft.Margin = new System.Windows.Forms.Padding(17, 2, 2, 2);
            this.BtnDraft.Name = "BtnDraft";
            this.BtnDraft.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnDraft.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.BtnDraft.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDraft.selected = false;
            this.BtnDraft.Size = new System.Drawing.Size(176, 51);
            this.BtnDraft.TabIndex = 4;
            this.BtnDraft.Text = "   Draft";
            this.BtnDraft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDraft.Textcolor = System.Drawing.Color.White;
            this.BtnDraft.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraft.Click += new System.EventHandler(this.BtnDraft_Click);
            // 
            // BtnSent
            // 
            this.BtnSent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnSent.BackColor = System.Drawing.Color.Transparent;
            this.BtnSent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSent.BorderRadius = 0;
            this.BtnSent.ButtonText = "   Sent";
            this.BtnSent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSent.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSent.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSent.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSent.Iconimage")));
            this.BtnSent.Iconimage_right = null;
            this.BtnSent.Iconimage_right_Selected = null;
            this.BtnSent.Iconimage_Selected = null;
            this.BtnSent.IconMarginLeft = 15;
            this.BtnSent.IconMarginRight = 0;
            this.BtnSent.IconRightVisible = true;
            this.BtnSent.IconRightZoom = 0D;
            this.BtnSent.IconVisible = true;
            this.BtnSent.IconZoom = 30D;
            this.BtnSent.IsTab = true;
            this.BtnSent.Location = new System.Drawing.Point(0, 155);
            this.BtnSent.Margin = new System.Windows.Forms.Padding(17, 2, 2, 2);
            this.BtnSent.Name = "BtnSent";
            this.BtnSent.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnSent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.BtnSent.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSent.selected = false;
            this.BtnSent.Size = new System.Drawing.Size(176, 51);
            this.BtnSent.TabIndex = 3;
            this.BtnSent.Text = "   Sent";
            this.BtnSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSent.Textcolor = System.Drawing.Color.White;
            this.BtnSent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSent.Click += new System.EventHandler(this.BtnSent_Click);
            // 
            // BtnInbox
            // 
            this.BtnInbox.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnInbox.BackColor = System.Drawing.Color.Transparent;
            this.BtnInbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInbox.BorderRadius = 0;
            this.BtnInbox.ButtonText = "   Inbox";
            this.BtnInbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInbox.DisabledColor = System.Drawing.Color.Gray;
            this.BtnInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInbox.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnInbox.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnInbox.Iconimage")));
            this.BtnInbox.Iconimage_right = null;
            this.BtnInbox.Iconimage_right_Selected = null;
            this.BtnInbox.Iconimage_Selected = null;
            this.BtnInbox.IconMarginLeft = 15;
            this.BtnInbox.IconMarginRight = 0;
            this.BtnInbox.IconRightVisible = true;
            this.BtnInbox.IconRightZoom = 0D;
            this.BtnInbox.IconVisible = true;
            this.BtnInbox.IconZoom = 30D;
            this.BtnInbox.IsTab = true;
            this.BtnInbox.Location = new System.Drawing.Point(0, 104);
            this.BtnInbox.Margin = new System.Windows.Forms.Padding(17, 2, 2, 2);
            this.BtnInbox.Name = "BtnInbox";
            this.BtnInbox.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnInbox.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.BtnInbox.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnInbox.selected = false;
            this.BtnInbox.Size = new System.Drawing.Size(176, 51);
            this.BtnInbox.TabIndex = 2;
            this.BtnInbox.Text = "   Inbox";
            this.BtnInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInbox.Textcolor = System.Drawing.Color.White;
            this.BtnInbox.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInbox.Click += new System.EventHandler(this.BtnInbox_Click);
            // 
            // BtnCompose
            // 
            this.BtnCompose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnCompose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnCompose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCompose.BorderRadius = 0;
            this.BtnCompose.ButtonText = "   Compose";
            this.BtnCompose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompose.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCompose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompose.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCompose.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCompose.Iconimage")));
            this.BtnCompose.Iconimage_right = null;
            this.BtnCompose.Iconimage_right_Selected = null;
            this.BtnCompose.Iconimage_Selected = null;
            this.BtnCompose.IconMarginLeft = 15;
            this.BtnCompose.IconMarginRight = 0;
            this.BtnCompose.IconRightVisible = false;
            this.BtnCompose.IconRightZoom = 0D;
            this.BtnCompose.IconVisible = true;
            this.BtnCompose.IconZoom = 30D;
            this.BtnCompose.IsTab = true;
            this.BtnCompose.Location = new System.Drawing.Point(0, 53);
            this.BtnCompose.Margin = new System.Windows.Forms.Padding(17, 2, 2, 2);
            this.BtnCompose.Name = "BtnCompose";
            this.BtnCompose.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnCompose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.BtnCompose.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCompose.selected = true;
            this.BtnCompose.Size = new System.Drawing.Size(176, 51);
            this.BtnCompose.TabIndex = 1;
            this.BtnCompose.Text = "   Compose";
            this.BtnCompose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompose.Textcolor = System.Drawing.Color.White;
            this.BtnCompose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompose.Click += new System.EventHandler(this.BtnCompose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.CurrentUser);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 53);
            this.panel3.TabIndex = 0;
            // 
            // CurrentUser
            // 
            this.CurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentUser.AutoSize = true;
            this.CurrentUser.Font = new System.Drawing.Font("Muli", 6F);
            this.CurrentUser.ForeColor = System.Drawing.Color.White;
            this.CurrentUser.Location = new System.Drawing.Point(16, 32);
            this.CurrentUser.Name = "CurrentUser";
            this.CurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CurrentUser.Size = new System.Drawing.Size(57, 11);
            this.CurrentUser.TabIndex = 4;
            this.CurrentUser.Text = "lsfldgkljdsflgk";
            this.CurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muli Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail.";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.BtnMin);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 53);
            this.panel2.TabIndex = 0;
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.ImageActive = null;
            this.BtnMin.Location = new System.Drawing.Point(577, 12);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(13, 13);
            this.BtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMin.TabIndex = 3;
            this.BtnMin.TabStop = false;
            this.BtnMin.Zoom = 8;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(599, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(13, 13);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 397);
            this.panel4.TabIndex = 1;
            // 
            // compose1
            // 
            this.compose1.BackColor = System.Drawing.Color.White;
            this.compose1.Location = new System.Drawing.Point(176, 53);
            this.compose1.Name = "compose1";
            this.compose1.Size = new System.Drawing.Size(624, 397);
            this.compose1.TabIndex = 1;
            // 
            // sent1
            // 
            this.sent1.BackColor = System.Drawing.Color.White;
            this.sent1.Location = new System.Drawing.Point(176, 53);
            this.sent1.Name = "sent1";
            this.sent1.Size = new System.Drawing.Size(624, 397);
            this.sent1.TabIndex = 3;
            // 
            // inbox1
            // 
            this.inbox1.BackColor = System.Drawing.Color.White;
            this.inbox1.Location = new System.Drawing.Point(176, 53);
            this.inbox1.Name = "inbox1";
            this.inbox1.Size = new System.Drawing.Size(619, 393);
            this.inbox1.TabIndex = 2;
            // 
            // draft1
            // 
            this.draft1.BackColor = System.Drawing.Color.White;
            this.draft1.Location = new System.Drawing.Point(176, 53);
            this.draft1.Name = "draft1";
            this.draft1.Size = new System.Drawing.Size(624, 397);
            this.draft1.TabIndex = 4;
            // 
            // bin1
            // 
            this.bin1.BackColor = System.Drawing.Color.White;
            this.bin1.Location = new System.Drawing.Point(176, 53);
            this.bin1.Name = "bin1";
            this.bin1.Size = new System.Drawing.Size(624, 397);
            this.bin1.TabIndex = 5;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.compose1);
            this.Controls.Add(this.sent1);
            this.Controls.Add(this.inbox1);
            this.Controls.Add(this.draft1);
            this.Controls.Add(this.bin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCompose;
        private Bunifu.Framework.UI.BunifuFlatButton BtnInbox;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSent;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDraft;
        private compose compose1;
        private inbox inbox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private sent sent1;
        private draft draft1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBin;
        private bin bin1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton BtnMin;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label CurrentUser;
    }
}

