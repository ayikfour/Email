namespace Email
{
    partial class ViewMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMessage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnReply = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RtbSubject = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RtbRecipient = new System.Windows.Forms.RichTextBox();
            this.RtbMessage = new System.Windows.Forms.RichTextBox();
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
            this.panel1.Size = new System.Drawing.Size(577, 53);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Muli Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inbox.";
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.ImageActive = null;
            this.BtnMin.Location = new System.Drawing.Point(451, 12);
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
            this.BtnClose.Location = new System.Drawing.Point(473, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(13, 13);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(400, 394);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 23;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnReply
            // 
            this.BtnReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnReply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnReply.FlatAppearance.BorderSize = 0;
            this.BtnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReply.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReply.ForeColor = System.Drawing.Color.White;
            this.BtnReply.Location = new System.Drawing.Point(481, 394);
            this.BtnReply.Name = "BtnReply";
            this.BtnReply.Size = new System.Drawing.Size(75, 23);
            this.BtnReply.TabIndex = 22;
            this.BtnReply.Text = "Reply";
            this.BtnReply.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel3.Location = new System.Drawing.Point(18, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 1);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel2.Location = new System.Drawing.Point(18, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 1);
            this.panel2.TabIndex = 17;
            // 
            // RtbSubject
            // 
            this.RtbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbSubject.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbSubject.Location = new System.Drawing.Point(78, 120);
            this.RtbSubject.Name = "RtbSubject";
            this.RtbSubject.Size = new System.Drawing.Size(260, 20);
            this.RtbSubject.TabIndex = 21;
            this.RtbSubject.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(15, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Subject :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Recipient :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel4.Location = new System.Drawing.Point(18, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 1);
            this.panel4.TabIndex = 16;
            // 
            // RtbRecipient
            // 
            this.RtbRecipient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbRecipient.Font = new System.Drawing.Font("Muli ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbRecipient.Location = new System.Drawing.Point(88, 73);
            this.RtbRecipient.Multiline = false;
            this.RtbRecipient.Name = "RtbRecipient";
            this.RtbRecipient.Size = new System.Drawing.Size(250, 20);
            this.RtbRecipient.TabIndex = 15;
            this.RtbRecipient.Text = "";
            // 
            // RtbMessage
            // 
            this.RtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbMessage.Font = new System.Drawing.Font("Muli", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbMessage.Location = new System.Drawing.Point(18, 166);
            this.RtbMessage.Name = "RtbMessage";
            this.RtbMessage.Size = new System.Drawing.Size(538, 202);
            this.RtbMessage.TabIndex = 14;
            this.RtbMessage.Text = "";
            // 
            // ViewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnReply);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RtbSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.RtbRecipient);
            this.Controls.Add(this.RtbMessage);
            this.Controls.Add(this.panel1);
            this.Name = "ViewMessage";
            this.Size = new System.Drawing.Size(577, 434);
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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnReply;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox RtbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox RtbRecipient;
        private System.Windows.Forms.RichTextBox RtbMessage;
    }
}
