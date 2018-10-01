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
            this.ListOutbox = new System.Windows.Forms.ListView();
            this.ColID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColRecipient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // ListOutbox
            // 
            this.ListOutbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListOutbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColID,
            this.ColRecipient,
            this.ColSubject,
            this.ColMessage});
            this.ListOutbox.Font = new System.Drawing.Font("Muli", 8F);
            this.ListOutbox.FullRowSelect = true;
            this.ListOutbox.Location = new System.Drawing.Point(6, 3);
            this.ListOutbox.MultiSelect = false;
            this.ListOutbox.Name = "ListOutbox";
            this.ListOutbox.Size = new System.Drawing.Size(615, 328);
            this.ListOutbox.TabIndex = 9;
            this.ListOutbox.UseCompatibleStateImageBehavior = false;
            this.ListOutbox.View = System.Windows.Forms.View.Details;
            this.ListOutbox.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListOutbox_ColumnWidthChanging);
            this.ListOutbox.SelectedIndexChanged += new System.EventHandler(this.ListOutbox_SelectedIndexChanged);
            this.ListOutbox.DoubleClick += new System.EventHandler(this.ListOutbox_DoubleClick);
            // 
            // ColID
            // 
            this.ColID.Text = "ID";
            this.ColID.Width = 0;
            // 
            // ColRecipient
            // 
            this.ColRecipient.Text = "Recipient";
            this.ColRecipient.Width = 80;
            // 
            // ColSubject
            // 
            this.ColSubject.Text = "Subject";
            this.ColSubject.Width = 80;
            // 
            // ColMessage
            // 
            this.ColMessage.Text = "Message";
            this.ColMessage.Width = 450;
            // 
            // sent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DelMail);
            this.Controls.Add(this.ListOutbox);
            this.Name = "sent";
            this.Size = new System.Drawing.Size(624, 397);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DelMail;
        private System.Windows.Forms.ListView ListOutbox;
        private System.Windows.Forms.ColumnHeader ColSubject;
        private System.Windows.Forms.ColumnHeader ColMessage;
        private System.Windows.Forms.ColumnHeader ColRecipient;
        private System.Windows.Forms.ColumnHeader ColID;
    }
}
