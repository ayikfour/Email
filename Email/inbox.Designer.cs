namespace Email
{
    partial class inbox
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
            this.ListInbox = new System.Windows.Forms.ListView();
            this.ColSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnDel = new System.Windows.Forms.Button();
            this.ColID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColRecipient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListInbox
            // 
            this.ListInbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColID,
            this.ColSender,
            this.ColRecipient,
            this.ColSubject,
            this.ColMessage});
            this.ListInbox.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListInbox.Location = new System.Drawing.Point(6, 3);
            this.ListInbox.MultiSelect = false;
            this.ListInbox.Name = "ListInbox";
            this.ListInbox.Size = new System.Drawing.Size(615, 328);
            this.ListInbox.TabIndex = 0;
            this.ListInbox.UseCompatibleStateImageBehavior = false;
            this.ListInbox.View = System.Windows.Forms.View.Details;
            this.ListInbox.SelectedIndexChanged += new System.EventHandler(this.ListInbox_SelectedIndexChanged);
            // 
            // ColSubject
            // 
            this.ColSubject.Text = "Subject";
            this.ColSubject.Width = 89;
            // 
            // ColMessage
            // 
            this.ColMessage.Text = "Message";
            this.ColMessage.Width = 394;
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDel.FlatAppearance.BorderSize = 0;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(507, 347);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 8;
            this.BtnDel.Text = "Delete";
            this.BtnDel.UseVisualStyleBackColor = false;
            // 
            // ColID
            // 
            this.ColID.Text = "ID";
            this.ColID.Width = 26;
            // 
            // ColRecipient
            // 
            this.ColRecipient.Text = "Recipient";
            this.ColRecipient.Width = 104;
            // 
            // ColSender
            // 
            this.ColSender.Text = "From";
            this.ColSender.Width = 89;
            // 
            // inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.ListInbox);
            this.Name = "inbox";
            this.Size = new System.Drawing.Size(624, 397);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListInbox;
        private System.Windows.Forms.ColumnHeader ColSubject;
        private System.Windows.Forms.ColumnHeader ColMessage;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.ColumnHeader ColID;
        private System.Windows.Forms.ColumnHeader ColRecipient;
        private System.Windows.Forms.ColumnHeader ColSender;
    }
}
