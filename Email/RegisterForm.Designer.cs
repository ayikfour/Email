namespace Email
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegName = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RegMailName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnMin);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 53);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Muli Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(22, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Registration.";
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.ImageActive = null;
            this.BtnMin.Location = new System.Drawing.Point(387, 12);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(13, 13);
            this.BtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMin.TabIndex = 5;
            this.BtnMin.TabStop = false;
            this.BtnMin.Zoom = 8;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(409, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(13, 13);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegister.BorderRadius = 0;
            this.BtnRegister.ButtonText = "Register";
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegister.Iconimage = null;
            this.BtnRegister.Iconimage_right = null;
            this.BtnRegister.Iconimage_right_Selected = null;
            this.BtnRegister.Iconimage_Selected = null;
            this.BtnRegister.IconMarginLeft = 0;
            this.BtnRegister.IconMarginRight = 0;
            this.BtnRegister.IconRightVisible = true;
            this.BtnRegister.IconRightZoom = 0D;
            this.BtnRegister.IconVisible = true;
            this.BtnRegister.IconZoom = 90D;
            this.BtnRegister.IsTab = false;
            this.BtnRegister.Location = new System.Drawing.Point(95, 338);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnRegister.selected = false;
            this.BtnRegister.Size = new System.Drawing.Size(244, 38);
            this.BtnRegister.TabIndex = 20;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegister.Textcolor = System.Drawing.Color.White;
            this.BtnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(93, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 1);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(95, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 1);
            this.panel2.TabIndex = 25;
            // 
            // RegName
            // 
            this.RegName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            this.RegName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegName.Font = new System.Drawing.Font("Muli ExtraBold", 8.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegName.ForeColor = System.Drawing.Color.White;
            this.RegName.Location = new System.Drawing.Point(95, 133);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(244, 18);
            this.RegName.TabIndex = 24;
            this.RegName.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(92, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(92, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(93, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 1);
            this.panel4.TabIndex = 29;
            // 
            // RegMailName
            // 
            this.RegMailName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            this.RegMailName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegMailName.Font = new System.Drawing.Font("Muli ExtraBold", 8.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegMailName.ForeColor = System.Drawing.Color.White;
            this.RegMailName.Location = new System.Drawing.Point(93, 261);
            this.RegMailName.Name = "RegMailName";
            this.RegMailName.Size = new System.Drawing.Size(244, 18);
            this.RegMailName.TabIndex = 30;
            this.RegMailName.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Email Name";
            // 
            // RegPassword
            // 
            this.RegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            this.RegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegPassword.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPassword.ForeColor = System.Drawing.Color.White;
            this.RegPassword.Location = new System.Drawing.Point(93, 198);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.PasswordChar = '*';
            this.RegPassword.Size = new System.Drawing.Size(242, 18);
            this.RegPassword.TabIndex = 31;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(430, 446);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.RegMailName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RegName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton BtnMin;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegister;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox RegName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox RegMailName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegPassword;
    }
}