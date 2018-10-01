namespace Email
{
    partial class draft
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.ListDraft = new System.Windows.Forms.ListView();
            this.ColID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColRecipient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(507, 347);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // ListDraft
            // 
            this.ListDraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListDraft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColID,
            this.ColRecipient,
            this.ColSubject,
            this.ColMessage});
            this.ListDraft.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDraft.FullRowSelect = true;
            this.ListDraft.Location = new System.Drawing.Point(6, 3);
            this.ListDraft.MultiSelect = false;
            this.ListDraft.Name = "ListDraft";
            this.ListDraft.Size = new System.Drawing.Size(615, 328);
            this.ListDraft.TabIndex = 11;
            this.ListDraft.UseCompatibleStateImageBehavior = false;
            this.ListDraft.View = System.Windows.Forms.View.Details;
            this.ListDraft.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListDraft_ColumnWidthChanging);
            this.ListDraft.SelectedIndexChanged += new System.EventHandler(this.ListDraft_SelectedIndexChanged);
            this.ListDraft.DoubleClick += new System.EventHandler(this.ListDraft_DoubleClick);
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
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSend.FlatAppearance.BorderSize = 0;
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSend.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.ForeColor = System.Drawing.Color.White;
            this.BtnSend.Location = new System.Drawing.Point(426, 347);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 13;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = false;
            // 
            // draft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.ListDraft);
            this.Name = "draft";
            this.Size = new System.Drawing.Size(624, 397);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ListView ListDraft;
        private System.Windows.Forms.ColumnHeader ColSubject;
        private System.Windows.Forms.ColumnHeader ColMessage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.ColumnHeader ColID;
        private System.Windows.Forms.ColumnHeader ColRecipient;
    }
}
