namespace Email
{
    partial class sent
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
            this.DelMail = new System.Windows.Forms.Button();
            this.ListInbox = new System.Windows.Forms.ListView();
            this.ColRecipient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DelMail
            // 
            this.DelMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.DelMail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelMail.FlatAppearance.BorderSize = 0;
            this.DelMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelMail.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelMail.ForeColor = System.Drawing.Color.White;
            this.DelMail.Location = new System.Drawing.Point(507, 347);
            this.DelMail.Name = "DelMail";
            this.DelMail.Size = new System.Drawing.Size(75, 23);
            this.DelMail.TabIndex = 10;
            this.DelMail.Text = "Delete";
            this.DelMail.UseVisualStyleBackColor = false;
            // 
            // ListInbox
            // 
            this.ListInbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColRecipient,
            this.ColSubject,
            this.ColMessage,
            this.ColTime});
            this.ListInbox.Font = new System.Drawing.Font("Muli", 8F);
            this.ListInbox.Location = new System.Drawing.Point(6, 3);
            this.ListInbox.Name = "ListInbox";
            this.ListInbox.Size = new System.Drawing.Size(615, 328);
            this.ListInbox.TabIndex = 9;
            this.ListInbox.UseCompatibleStateImageBehavior = false;
            this.ListInbox.View = System.Windows.Forms.View.Details;
            // 
            // ColRecipient
            // 
            this.ColRecipient.Text = "Recipient";
            this.ColRecipient.Width = 100;
            // 
            // ColSubject
            // 
            this.ColSubject.Text = "Subject";
            this.ColSubject.Width = 62;
            // 
            // ColMessage
            // 
            this.ColMessage.Text = "Message";
            this.ColMessage.Width = 382;
            // 
            // ColTime
            // 
            this.ColTime.Text = "Time";
            // 
            // sent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DelMail);
            this.Controls.Add(this.ListInbox);
            this.Name = "sent";
            this.Size = new System.Drawing.Size(624, 397);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DelMail;
        private System.Windows.Forms.ListView ListInbox;
        private System.Windows.Forms.ColumnHeader ColSubject;
        private System.Windows.Forms.ColumnHeader ColMessage;
        private System.Windows.Forms.ColumnHeader ColTime;
        private System.Windows.Forms.ColumnHeader ColRecipient;
    }
}
